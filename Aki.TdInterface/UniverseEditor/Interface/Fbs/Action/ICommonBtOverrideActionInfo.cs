using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD0 RID: 27344
	public struct ICommonBtOverrideActionInfo : IFlatbufferObject
	{
		// Token: 0x1700C8CB RID: 51403
		// (get) Token: 0x0602EF05 RID: 192261 RVA: 0x00664C26 File Offset: 0x00662E26
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EF06 RID: 192262 RVA: 0x00664C33 File Offset: 0x00662E33
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EF07 RID: 192263 RVA: 0x00664C3C File Offset: 0x00662E3C
		public static ICommonBtOverrideActionInfo GetRootAsICommonBtOverrideActionInfo(ByteBuffer _bb)
		{
			return ICommonBtOverrideActionInfo.GetRootAsICommonBtOverrideActionInfo(_bb, default(ICommonBtOverrideActionInfo));
		}

		// Token: 0x0602EF08 RID: 192264 RVA: 0x00664C58 File Offset: 0x00662E58
		public static ICommonBtOverrideActionInfo GetRootAsICommonBtOverrideActionInfo(ByteBuffer _bb, ICommonBtOverrideActionInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EF09 RID: 192265 RVA: 0x00664C75 File Offset: 0x00662E75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EF0A RID: 192266 RVA: 0x00664C84 File Offset: 0x00662E84
		public ICommonBtOverrideActionInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8CC RID: 51404
		// (get) Token: 0x0602EF0B RID: 192267 RVA: 0x00664C94 File Offset: 0x00662E94
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

		// Token: 0x1700C8CD RID: 51405
		// (get) Token: 0x0602EF0C RID: 192268 RVA: 0x00664CD0 File Offset: 0x00662ED0
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

		// Token: 0x0602EF0D RID: 192269 RVA: 0x00664D2D File Offset: 0x00662F2D
		public static Offset<ICommonBtOverrideActionInfo> CreateICommonBtOverrideActionInfo(FlatBufferBuilder builder, ECommonBtPlaceholderTargetType Type = ECommonBtPlaceholderTargetType.Action, Offset<IActionInfo> ActionOffset = default(Offset<IActionInfo>))
		{
			builder.StartTable(2);
			ICommonBtOverrideActionInfo.AddAction(builder, ActionOffset);
			ICommonBtOverrideActionInfo.AddType(builder, Type);
			return ICommonBtOverrideActionInfo.EndICommonBtOverrideActionInfo(builder);
		}

		// Token: 0x0602EF0E RID: 192270 RVA: 0x00664D4A File Offset: 0x00662F4A
		public static void StartICommonBtOverrideActionInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EF0F RID: 192271 RVA: 0x00664D53 File Offset: 0x00662F53
		public static void AddType(FlatBufferBuilder builder, ECommonBtPlaceholderTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EF10 RID: 192272 RVA: 0x00664D5E File Offset: 0x00662F5E
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(1, actionOffset.Value, 0);
		}

		// Token: 0x0602EF11 RID: 192273 RVA: 0x00664D6E File Offset: 0x00662F6E
		public static Offset<ICommonBtOverrideActionInfo> EndICommonBtOverrideActionInfo(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtOverrideActionInfo>(builder.EndTable());
		}

		// Token: 0x0602EF12 RID: 192274 RVA: 0x00664D7C File Offset: 0x00662F7C
		public ICommonBtOverrideActionInfoT UnPack()
		{
			ICommonBtOverrideActionInfoT commonBtOverrideActionInfoT = new ICommonBtOverrideActionInfoT();
			this.UnPackTo(commonBtOverrideActionInfoT);
			return commonBtOverrideActionInfoT;
		}

		// Token: 0x0602EF13 RID: 192275 RVA: 0x00664D98 File Offset: 0x00662F98
		public void UnPackTo(ICommonBtOverrideActionInfoT _o)
		{
			_o.Type = this.Type;
			_o.Action = ((this.Action != null) ? this.Action.Value.UnPack() : null);
		}

		// Token: 0x0602EF14 RID: 192276 RVA: 0x00664DE0 File Offset: 0x00662FE0
		public static Offset<ICommonBtOverrideActionInfo> Pack(FlatBufferBuilder builder, ICommonBtOverrideActionInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtOverrideActionInfo>);
			}
			Offset<IActionInfo> actionOffset = (_o.Action == null) ? default(Offset<IActionInfo>) : IActionInfo.Pack(builder, _o.Action);
			return ICommonBtOverrideActionInfo.CreateICommonBtOverrideActionInfo(builder, _o.Type, actionOffset);
		}

		// Token: 0x04011871 RID: 71793
		private Table __p;
	}
}
