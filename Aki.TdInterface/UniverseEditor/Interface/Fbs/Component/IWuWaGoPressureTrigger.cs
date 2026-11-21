using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061E3 RID: 25059
	public struct IWuWaGoPressureTrigger : IFlatbufferObject
	{
		// Token: 0x1700BAD9 RID: 47833
		// (get) Token: 0x0602A9E9 RID: 174569 RVA: 0x005CFAF0 File Offset: 0x005CDCF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A9EA RID: 174570 RVA: 0x005CFAFD File Offset: 0x005CDCFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A9EB RID: 174571 RVA: 0x005CFB04 File Offset: 0x005CDD04
		public static IWuWaGoPressureTrigger GetRootAsIWuWaGoPressureTrigger(ByteBuffer _bb)
		{
			return IWuWaGoPressureTrigger.GetRootAsIWuWaGoPressureTrigger(_bb, default(IWuWaGoPressureTrigger));
		}

		// Token: 0x0602A9EC RID: 174572 RVA: 0x005CFB20 File Offset: 0x005CDD20
		public static IWuWaGoPressureTrigger GetRootAsIWuWaGoPressureTrigger(ByteBuffer _bb, IWuWaGoPressureTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A9ED RID: 174573 RVA: 0x005CFB3D File Offset: 0x005CDD3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A9EE RID: 174574 RVA: 0x005CFB4C File Offset: 0x005CDD4C
		public IWuWaGoPressureTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BADA RID: 47834
		// (get) Token: 0x0602A9EF RID: 174575 RVA: 0x005CFB5C File Offset: 0x005CDD5C
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

		// Token: 0x1700BADB RID: 47835
		// (get) Token: 0x0602A9F0 RID: 174576 RVA: 0x005CFB98 File Offset: 0x005CDD98
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

		// Token: 0x0602A9F1 RID: 174577 RVA: 0x005CFBEC File Offset: 0x005CDDEC
		public IActionInfo? EnterActionList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BADC RID: 47836
		// (get) Token: 0x0602A9F2 RID: 174578 RVA: 0x005CFC4C File Offset: 0x005CDE4C
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

		// Token: 0x0602A9F3 RID: 174579 RVA: 0x005CFC78 File Offset: 0x005CDE78
		public IActionInfo? ExitActionList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BADD RID: 47837
		// (get) Token: 0x0602A9F4 RID: 174580 RVA: 0x005CFCDC File Offset: 0x005CDEDC
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

		// Token: 0x0602A9F5 RID: 174581 RVA: 0x005CFD08 File Offset: 0x005CDF08
		public static Offset<IWuWaGoPressureTrigger> CreateIWuWaGoPressureTrigger(FlatBufferBuilder builder, EWuWaGoEntityType Type = EWuWaGoEntityType.LevelCenter, IWuWaGoGridLinkDataT LinkData = null, VectorOffset EnterActionListOffset = default(VectorOffset), VectorOffset ExitActionListOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IWuWaGoPressureTrigger.AddExitActionList(builder, ExitActionListOffset);
			IWuWaGoPressureTrigger.AddEnterActionList(builder, EnterActionListOffset);
			IWuWaGoPressureTrigger.AddLinkData(builder, IWuWaGoGridLinkData.Pack(builder, LinkData));
			IWuWaGoPressureTrigger.AddType(builder, Type);
			return IWuWaGoPressureTrigger.EndIWuWaGoPressureTrigger(builder);
		}

		// Token: 0x0602A9F6 RID: 174582 RVA: 0x005CFD3A File Offset: 0x005CDF3A
		public static void StartIWuWaGoPressureTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602A9F7 RID: 174583 RVA: 0x005CFD43 File Offset: 0x005CDF43
		public static void AddType(FlatBufferBuilder builder, EWuWaGoEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A9F8 RID: 174584 RVA: 0x005CFD4E File Offset: 0x005CDF4E
		public static void AddLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> linkDataOffset)
		{
			builder.AddStruct(1, linkDataOffset.Value, 0);
		}

		// Token: 0x0602A9F9 RID: 174585 RVA: 0x005CFD5E File Offset: 0x005CDF5E
		public static void AddEnterActionList(FlatBufferBuilder builder, VectorOffset enterActionListOffset)
		{
			builder.AddOffset(2, enterActionListOffset.Value, 0);
		}

		// Token: 0x0602A9FA RID: 174586 RVA: 0x005CFD70 File Offset: 0x005CDF70
		public static VectorOffset CreateEnterActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A9FB RID: 174587 RVA: 0x005CFDB0 File Offset: 0x005CDFB0
		public static VectorOffset CreateEnterActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A9FC RID: 174588 RVA: 0x005CFDCA File Offset: 0x005CDFCA
		public static VectorOffset CreateEnterActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A9FD RID: 174589 RVA: 0x005CFDE8 File Offset: 0x005CDFE8
		public static VectorOffset CreateEnterActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A9FE RID: 174590 RVA: 0x005CFE01 File Offset: 0x005CE001
		public static void StartEnterActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A9FF RID: 174591 RVA: 0x005CFE0C File Offset: 0x005CE00C
		public static void AddExitActionList(FlatBufferBuilder builder, VectorOffset exitActionListOffset)
		{
			builder.AddOffset(3, exitActionListOffset.Value, 0);
		}

		// Token: 0x0602AA00 RID: 174592 RVA: 0x005CFE1C File Offset: 0x005CE01C
		public static VectorOffset CreateExitActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602AA01 RID: 174593 RVA: 0x005CFE5C File Offset: 0x005CE05C
		public static VectorOffset CreateExitActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AA02 RID: 174594 RVA: 0x005CFE76 File Offset: 0x005CE076
		public static VectorOffset CreateExitActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602AA03 RID: 174595 RVA: 0x005CFE94 File Offset: 0x005CE094
		public static VectorOffset CreateExitActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602AA04 RID: 174596 RVA: 0x005CFEAD File Offset: 0x005CE0AD
		public static void StartExitActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602AA05 RID: 174597 RVA: 0x005CFEB8 File Offset: 0x005CE0B8
		public static Offset<IWuWaGoPressureTrigger> EndIWuWaGoPressureTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoPressureTrigger>(builder.EndTable());
		}

		// Token: 0x0602AA06 RID: 174598 RVA: 0x005CFEC8 File Offset: 0x005CE0C8
		public IWuWaGoPressureTriggerT UnPack()
		{
			IWuWaGoPressureTriggerT wuWaGoPressureTriggerT = new IWuWaGoPressureTriggerT();
			this.UnPackTo(wuWaGoPressureTriggerT);
			return wuWaGoPressureTriggerT;
		}

		// Token: 0x0602AA07 RID: 174599 RVA: 0x005CFEE4 File Offset: 0x005CE0E4
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

		// Token: 0x0602AA08 RID: 174600 RVA: 0x005CFFD8 File Offset: 0x005CE1D8
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

		// Token: 0x0401004F RID: 65615
		private Table __p;
	}
}
