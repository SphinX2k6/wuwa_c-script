using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FA9 RID: 20393
	public struct IClientHookActionConfig : IFlatbufferObject
	{
		// Token: 0x170093AA RID: 37802
		// (get) Token: 0x06020725 RID: 132901 RVA: 0x00483947 File Offset: 0x00481B47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020726 RID: 132902 RVA: 0x00483954 File Offset: 0x00481B54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020727 RID: 132903 RVA: 0x0048395C File Offset: 0x00481B5C
		public static IClientHookActionConfig GetRootAsIClientHookActionConfig(ByteBuffer _bb)
		{
			return IClientHookActionConfig.GetRootAsIClientHookActionConfig(_bb, default(IClientHookActionConfig));
		}

		// Token: 0x06020728 RID: 132904 RVA: 0x00483978 File Offset: 0x00481B78
		public static IClientHookActionConfig GetRootAsIClientHookActionConfig(ByteBuffer _bb, IClientHookActionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020729 RID: 132905 RVA: 0x00483995 File Offset: 0x00481B95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602072A RID: 132906 RVA: 0x004839A4 File Offset: 0x00481BA4
		public IClientHookActionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602072B RID: 132907 RVA: 0x004839B4 File Offset: 0x00481BB4
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170093AB RID: 37803
		// (get) Token: 0x0602072C RID: 132908 RVA: 0x00483A14 File Offset: 0x00481C14
		public int HookActionsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602072D RID: 132909 RVA: 0x00483A40 File Offset: 0x00481C40
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170093AC RID: 37804
		// (get) Token: 0x0602072E RID: 132910 RVA: 0x00483AA0 File Offset: 0x00481CA0
		public int ExitHookActionsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602072F RID: 132911 RVA: 0x00483ACC File Offset: 0x00481CCC
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170093AD RID: 37805
		// (get) Token: 0x06020730 RID: 132912 RVA: 0x00483B2C File Offset: 0x00481D2C
		public int FinishActionsLength
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

		// Token: 0x170093AE RID: 37806
		// (get) Token: 0x06020731 RID: 132913 RVA: 0x00483B58 File Offset: 0x00481D58
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020732 RID: 132914 RVA: 0x00483B95 File Offset: 0x00481D95
		public static Offset<IClientHookActionConfig> CreateIClientHookActionConfig(FlatBufferBuilder builder, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IClientHookActionConfig.AddFinishActions(builder, FinishActionsOffset);
			IClientHookActionConfig.AddExitHookActions(builder, ExitHookActionsOffset);
			IClientHookActionConfig.AddHookActions(builder, HookActionsOffset);
			IClientHookActionConfig.AddNullMask(builder, NullMask);
			return IClientHookActionConfig.EndIClientHookActionConfig(builder);
		}

		// Token: 0x06020733 RID: 132915 RVA: 0x00483BC1 File Offset: 0x00481DC1
		public static void StartIClientHookActionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020734 RID: 132916 RVA: 0x00483BCA File Offset: 0x00481DCA
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(0, hookActionsOffset.Value, 0);
		}

		// Token: 0x06020735 RID: 132917 RVA: 0x00483BDC File Offset: 0x00481DDC
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020736 RID: 132918 RVA: 0x00483C1C File Offset: 0x00481E1C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020737 RID: 132919 RVA: 0x00483C36 File Offset: 0x00481E36
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020738 RID: 132920 RVA: 0x00483C54 File Offset: 0x00481E54
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020739 RID: 132921 RVA: 0x00483C6D File Offset: 0x00481E6D
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602073A RID: 132922 RVA: 0x00483C78 File Offset: 0x00481E78
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(1, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x0602073B RID: 132923 RVA: 0x00483C88 File Offset: 0x00481E88
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602073C RID: 132924 RVA: 0x00483CC8 File Offset: 0x00481EC8
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602073D RID: 132925 RVA: 0x00483CE2 File Offset: 0x00481EE2
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602073E RID: 132926 RVA: 0x00483D00 File Offset: 0x00481F00
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602073F RID: 132927 RVA: 0x00483D19 File Offset: 0x00481F19
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020740 RID: 132928 RVA: 0x00483D24 File Offset: 0x00481F24
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(2, finishActionsOffset.Value, 0);
		}

		// Token: 0x06020741 RID: 132929 RVA: 0x00483D34 File Offset: 0x00481F34
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020742 RID: 132930 RVA: 0x00483D74 File Offset: 0x00481F74
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020743 RID: 132931 RVA: 0x00483D8E File Offset: 0x00481F8E
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020744 RID: 132932 RVA: 0x00483DAC File Offset: 0x00481FAC
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020745 RID: 132933 RVA: 0x00483DC5 File Offset: 0x00481FC5
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020746 RID: 132934 RVA: 0x00483DD0 File Offset: 0x00481FD0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06020747 RID: 132935 RVA: 0x00483DDB File Offset: 0x00481FDB
		public static Offset<IClientHookActionConfig> EndIClientHookActionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IClientHookActionConfig>(builder.EndTable());
		}

		// Token: 0x06020748 RID: 132936 RVA: 0x00483DE8 File Offset: 0x00481FE8
		public IClientHookActionConfigT UnPack()
		{
			IClientHookActionConfigT clientHookActionConfigT = new IClientHookActionConfigT();
			this.UnPackTo(clientHookActionConfigT);
			return clientHookActionConfigT;
		}

		// Token: 0x06020749 RID: 132937 RVA: 0x00483E04 File Offset: 0x00482004
		public void UnPackTo(IClientHookActionConfigT _o)
		{
			_o.HookActions = new List<IActionInfoT>();
			for (int i = 0; i < this.HookActionsLength; i++)
			{
				_o.HookActions.Add((this.HookActions(i) != null) ? this.HookActions(i).Value.UnPack() : null);
			}
			_o.ExitHookActions = new List<IActionInfoT>();
			for (int j = 0; j < this.ExitHookActionsLength; j++)
			{
				_o.ExitHookActions.Add((this.ExitHookActions(j) != null) ? this.ExitHookActions(j).Value.UnPack() : null);
			}
			_o.FinishActions = new List<IActionInfoT>();
			for (int k = 0; k < this.FinishActionsLength; k++)
			{
				_o.FinishActions.Add((this.FinishActions(k) != null) ? this.FinishActions(k).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602074A RID: 132938 RVA: 0x00483F1C File Offset: 0x0048211C
		public static Offset<IClientHookActionConfig> Pack(FlatBufferBuilder builder, IClientHookActionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientHookActionConfig>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IClientHookActionConfig.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IClientHookActionConfig.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IClientHookActionConfig.CreateFinishActionsVector(builder, array3);
			}
			return IClientHookActionConfig.CreateIClientHookActionConfig(builder, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, _o.NullMask);
		}

		// Token: 0x0400DE7D RID: 56957
		private Table __p;
	}
}
