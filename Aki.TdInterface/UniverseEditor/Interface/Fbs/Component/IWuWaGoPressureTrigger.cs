using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BCD RID: 23501
	public struct IWuWaGoPressureTrigger : IFlatbufferObject
	{
		// Token: 0x1700B191 RID: 45457
		// (get) Token: 0x06028425 RID: 164901 RVA: 0x00588060 File Offset: 0x00586260
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028426 RID: 164902 RVA: 0x0058806D File Offset: 0x0058626D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028427 RID: 164903 RVA: 0x00588074 File Offset: 0x00586274
		public static IWuWaGoPressureTrigger GetRootAsIWuWaGoPressureTrigger(ByteBuffer _bb)
		{
			return IWuWaGoPressureTrigger.GetRootAsIWuWaGoPressureTrigger(_bb, default(IWuWaGoPressureTrigger));
		}

		// Token: 0x06028428 RID: 164904 RVA: 0x00588090 File Offset: 0x00586290
		public static IWuWaGoPressureTrigger GetRootAsIWuWaGoPressureTrigger(ByteBuffer _bb, IWuWaGoPressureTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028429 RID: 164905 RVA: 0x005880AD File Offset: 0x005862AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602842A RID: 164906 RVA: 0x005880BC File Offset: 0x005862BC
		public IWuWaGoPressureTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B192 RID: 45458
		// (get) Token: 0x0602842B RID: 164907 RVA: 0x005880CC File Offset: 0x005862CC
		public EWuWaGoEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return (EWuWaGoEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B193 RID: 45459
		// (get) Token: 0x0602842C RID: 164908 RVA: 0x00588108 File Offset: 0x00586308
		public IWuWaGoGridLinkData? LinkData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IWuWaGoGridLinkData?(default(IWuWaGoGridLinkData).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x0602842D RID: 164909 RVA: 0x0058815C File Offset: 0x0058635C
		public IActionInfo? EnterActionList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B194 RID: 45460
		// (get) Token: 0x0602842E RID: 164910 RVA: 0x005881BC File Offset: 0x005863BC
		public int EnterActionListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602842F RID: 164911 RVA: 0x005881E8 File Offset: 0x005863E8
		public IActionInfo? ExitActionList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B195 RID: 45461
		// (get) Token: 0x06028430 RID: 164912 RVA: 0x0058824C File Offset: 0x0058644C
		public int ExitActionListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06028431 RID: 164913 RVA: 0x00588278 File Offset: 0x00586478
		public static Offset<IWuWaGoPressureTrigger> CreateIWuWaGoPressureTrigger(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, IWuWaGoGridLinkDataT LinkData = null, VectorOffset EnterActionListOffset = default(VectorOffset), VectorOffset ExitActionListOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IWuWaGoPressureTrigger.AddExitActionList(builder, ExitActionListOffset);
			IWuWaGoPressureTrigger.AddEnterActionList(builder, EnterActionListOffset);
			IWuWaGoPressureTrigger.AddLinkData(builder, IWuWaGoGridLinkData.Pack(builder, LinkData));
			IWuWaGoPressureTrigger.AddType(builder, Type);
			return IWuWaGoPressureTrigger.EndIWuWaGoPressureTrigger(builder);
		}

		// Token: 0x06028432 RID: 164914 RVA: 0x005882AA File Offset: 0x005864AA
		public static void StartIWuWaGoPressureTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06028433 RID: 164915 RVA: 0x005882B3 File Offset: 0x005864B3
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028434 RID: 164916 RVA: 0x005882BE File Offset: 0x005864BE
		public static void AddLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> linkDataOffset)
		{
			builder.AddStruct(1, linkDataOffset.Value, 0);
		}

		// Token: 0x06028435 RID: 164917 RVA: 0x005882CE File Offset: 0x005864CE
		public static void AddEnterActionList(FlatBufferBuilder builder, VectorOffset enterActionListOffset)
		{
			builder.AddOffset(2, enterActionListOffset.Value, 0);
		}

		// Token: 0x06028436 RID: 164918 RVA: 0x005882E0 File Offset: 0x005864E0
		public static VectorOffset CreateEnterActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028437 RID: 164919 RVA: 0x00588320 File Offset: 0x00586520
		public static VectorOffset CreateEnterActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028438 RID: 164920 RVA: 0x0058833A File Offset: 0x0058653A
		public static VectorOffset CreateEnterActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028439 RID: 164921 RVA: 0x00588358 File Offset: 0x00586558
		public static VectorOffset CreateEnterActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602843A RID: 164922 RVA: 0x00588371 File Offset: 0x00586571
		public static void StartEnterActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602843B RID: 164923 RVA: 0x0058837C File Offset: 0x0058657C
		public static void AddExitActionList(FlatBufferBuilder builder, VectorOffset exitActionListOffset)
		{
			builder.AddOffset(3, exitActionListOffset.Value, 0);
		}

		// Token: 0x0602843C RID: 164924 RVA: 0x0058838C File Offset: 0x0058658C
		public static VectorOffset CreateExitActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602843D RID: 164925 RVA: 0x005883CC File Offset: 0x005865CC
		public static VectorOffset CreateExitActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602843E RID: 164926 RVA: 0x005883E6 File Offset: 0x005865E6
		public static VectorOffset CreateExitActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602843F RID: 164927 RVA: 0x00588404 File Offset: 0x00586604
		public static VectorOffset CreateExitActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028440 RID: 164928 RVA: 0x0058841D File Offset: 0x0058661D
		public static void StartExitActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028441 RID: 164929 RVA: 0x00588428 File Offset: 0x00586628
		public static Offset<IWuWaGoPressureTrigger> EndIWuWaGoPressureTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoPressureTrigger>(builder.EndTable());
		}

		// Token: 0x06028442 RID: 164930 RVA: 0x00588438 File Offset: 0x00586638
		public IWuWaGoPressureTriggerT UnPack()
		{
			IWuWaGoPressureTriggerT wuWaGoPressureTriggerT = new IWuWaGoPressureTriggerT();
			this.UnPackTo(wuWaGoPressureTriggerT);
			return wuWaGoPressureTriggerT;
		}

		// Token: 0x06028443 RID: 164931 RVA: 0x00588454 File Offset: 0x00586654
		public void UnPackTo(IWuWaGoPressureTriggerT _o)
		{
			_o.Type = this.Type;
			_o.LinkData = ((this.LinkData != null) ? this.LinkData.Value.UnPack() : null);
			_o.EnterActionList = new List<IActionInfoT>();
			for (int i = 0; i < this.EnterActionListLength; i++)
			{
				_o.EnterActionList.Add((this.EnterActionList(i) != null) ? this.EnterActionList(i).Value.UnPack() : null);
			}
			_o.ExitActionList = new List<IActionInfoT>();
			for (int j = 0; j < this.ExitActionListLength; j++)
			{
				_o.ExitActionList.Add((this.ExitActionList(j) != null) ? this.ExitActionList(j).Value.UnPack() : null);
			}
		}

		// Token: 0x06028444 RID: 164932 RVA: 0x00588548 File Offset: 0x00586748
		public static Offset<IWuWaGoPressureTrigger> Pack(FlatBufferBuilder builder, IWuWaGoPressureTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoPressureTrigger>);
			}
			VectorOffset enterActionListOffset = default(VectorOffset);
			if (_o.EnterActionList != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.EnterActionList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.EnterActionList[i]);
				}
				enterActionListOffset = IWuWaGoPressureTrigger.CreateEnterActionListVector(builder, array);
			}
			VectorOffset exitActionListOffset = default(VectorOffset);
			if (_o.ExitActionList != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitActionList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitActionList[j]);
				}
				exitActionListOffset = IWuWaGoPressureTrigger.CreateExitActionListVector(builder, array2);
			}
			return IWuWaGoPressureTrigger.CreateIWuWaGoPressureTrigger(builder, _o.Type, _o.LinkData, enterActionListOffset, exitActionListOffset);
		}

		// Token: 0x0400F349 RID: 62281
		private Table __p;
	}
}
