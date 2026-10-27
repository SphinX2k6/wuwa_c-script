using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006468 RID: 25704
	public struct ICommonBtOverrideActionInfo : IFlatbufferObject
	{
		// Token: 0x1700BF49 RID: 48969
		// (get) Token: 0x0602C7C0 RID: 182208 RVA: 0x00619B5A File Offset: 0x00617D5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C7C1 RID: 182209 RVA: 0x00619B67 File Offset: 0x00617D67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C7C2 RID: 182210 RVA: 0x00619B70 File Offset: 0x00617D70
		public static ICommonBtOverrideActionInfo GetRootAsICommonBtOverrideActionInfo(ByteBuffer _bb)
		{
			return ICommonBtOverrideActionInfo.GetRootAsICommonBtOverrideActionInfo(_bb, default(ICommonBtOverrideActionInfo));
		}

		// Token: 0x0602C7C3 RID: 182211 RVA: 0x00619B8C File Offset: 0x00617D8C
		public static ICommonBtOverrideActionInfo GetRootAsICommonBtOverrideActionInfo(ByteBuffer _bb, ICommonBtOverrideActionInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C7C4 RID: 182212 RVA: 0x00619BA9 File Offset: 0x00617DA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C7C5 RID: 182213 RVA: 0x00619BB8 File Offset: 0x00617DB8
		public ICommonBtOverrideActionInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF4A RID: 48970
		// (get) Token: 0x0602C7C6 RID: 182214 RVA: 0x00619BC8 File Offset: 0x00617DC8
		public ECommonBtPlaceholderTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonBtPlaceholderTargetType.Action;
				}
				return (ECommonBtPlaceholderTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF4B RID: 48971
		// (get) Token: 0x0602C7C7 RID: 182215 RVA: 0x00619C04 File Offset: 0x00617E04
		public IActionInfo? Action
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602C7C8 RID: 182216 RVA: 0x00619C61 File Offset: 0x00617E61
		public static Offset<ICommonBtOverrideActionInfo> CreateICommonBtOverrideActionInfo(FlatBufferBuilder builder, ECommonBtPlaceholderTargetType Type = ECommonBtPlaceholderTargetType.Action, Offset<IActionInfo> ActionOffset = default(Offset<IActionInfo>))
		{
			builder.StartTable(2);
			ICommonBtOverrideActionInfo.AddAction(builder, ActionOffset);
			ICommonBtOverrideActionInfo.AddType(builder, Type);
			return ICommonBtOverrideActionInfo.EndICommonBtOverrideActionInfo(builder);
		}

		// Token: 0x0602C7C9 RID: 182217 RVA: 0x00619C7E File Offset: 0x00617E7E
		public static void StartICommonBtOverrideActionInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C7CA RID: 182218 RVA: 0x00619C87 File Offset: 0x00617E87
		public static void AddType(FlatBufferBuilder builder, ECommonBtPlaceholderTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C7CB RID: 182219 RVA: 0x00619C92 File Offset: 0x00617E92
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(1, actionOffset.Value, 0);
		}

		// Token: 0x0602C7CC RID: 182220 RVA: 0x00619CA2 File Offset: 0x00617EA2
		public static Offset<ICommonBtOverrideActionInfo> EndICommonBtOverrideActionInfo(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtOverrideActionInfo>(builder.EndTable());
		}

		// Token: 0x0602C7CD RID: 182221 RVA: 0x00619CB0 File Offset: 0x00617EB0
		public ICommonBtOverrideActionInfoT UnPack()
		{
			ICommonBtOverrideActionInfoT commonBtOverrideActionInfoT = new ICommonBtOverrideActionInfoT();
			this.UnPackTo(commonBtOverrideActionInfoT);
			return commonBtOverrideActionInfoT;
		}

		// Token: 0x0602C7CE RID: 182222 RVA: 0x00619CCC File Offset: 0x00617ECC
		public void UnPackTo(ICommonBtOverrideActionInfoT _o)
		{
			_o.Type = this.Type;
			_o.Action = ((this.Action != null) ? this.Action.Value.UnPack() : null);
		}

		// Token: 0x0602C7CF RID: 182223 RVA: 0x00619D14 File Offset: 0x00617F14
		public static Offset<ICommonBtOverrideActionInfo> Pack(FlatBufferBuilder builder, ICommonBtOverrideActionInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtOverrideActionInfo>);
			}
			Offset<IActionInfo> actionOffset = (_o.Action == null) ? default(Offset<IActionInfo>) : IActionInfo.Pack(builder, _o.Action);
			return ICommonBtOverrideActionInfo.CreateICommonBtOverrideActionInfo(builder, _o.Type, actionOffset);
		}

		// Token: 0x04010A66 RID: 68198
		private Table __p;
	}
}
