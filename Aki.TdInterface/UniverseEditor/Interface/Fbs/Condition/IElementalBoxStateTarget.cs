using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C0A RID: 19466
	public struct IElementalBoxStateTarget : IFlatbufferObject
	{
		// Token: 0x17008D68 RID: 36200
		// (get) Token: 0x0601ED43 RID: 126275 RVA: 0x0045121E File Offset: 0x0044F41E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ED44 RID: 126276 RVA: 0x0045122B File Offset: 0x0044F42B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ED45 RID: 126277 RVA: 0x00451234 File Offset: 0x0044F434
		public static IElementalBoxStateTarget GetRootAsIElementalBoxStateTarget(ByteBuffer _bb)
		{
			return IElementalBoxStateTarget.GetRootAsIElementalBoxStateTarget(_bb, default(IElementalBoxStateTarget));
		}

		// Token: 0x0601ED46 RID: 126278 RVA: 0x00451250 File Offset: 0x0044F450
		public static IElementalBoxStateTarget GetRootAsIElementalBoxStateTarget(ByteBuffer _bb, IElementalBoxStateTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ED47 RID: 126279 RVA: 0x0045126D File Offset: 0x0044F46D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ED48 RID: 126280 RVA: 0x0045127C File Offset: 0x0044F47C
		public IElementalBoxStateTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D69 RID: 36201
		// (get) Token: 0x0601ED49 RID: 126281 RVA: 0x0045128C File Offset: 0x0044F48C
		public EElementalBoxStateTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalBoxStateTargetType.Player;
				}
				return (EElementalBoxStateTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ED4A RID: 126282 RVA: 0x004512C8 File Offset: 0x0044F4C8
		public static Offset<IElementalBoxStateTarget> CreateIElementalBoxStateTarget(FlatBufferBuilder builder, EElementalBoxStateTargetType Type = EElementalBoxStateTargetType.Player)
		{
			builder.StartTable(1);
			IElementalBoxStateTarget.AddType(builder, Type);
			return IElementalBoxStateTarget.EndIElementalBoxStateTarget(builder);
		}

		// Token: 0x0601ED4B RID: 126283 RVA: 0x004512DE File Offset: 0x0044F4DE
		public static void StartIElementalBoxStateTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601ED4C RID: 126284 RVA: 0x004512E7 File Offset: 0x0044F4E7
		public static void AddType(FlatBufferBuilder builder, EElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ED4D RID: 126285 RVA: 0x004512F2 File Offset: 0x0044F4F2
		public static Offset<IElementalBoxStateTarget> EndIElementalBoxStateTarget(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxStateTarget>(builder.EndTable());
		}

		// Token: 0x0601ED4E RID: 126286 RVA: 0x00451300 File Offset: 0x0044F500
		public IElementalBoxStateTargetT UnPack()
		{
			IElementalBoxStateTargetT elementalBoxStateTargetT = new IElementalBoxStateTargetT();
			this.UnPackTo(elementalBoxStateTargetT);
			return elementalBoxStateTargetT;
		}

		// Token: 0x0601ED4F RID: 126287 RVA: 0x0045131B File Offset: 0x0044F51B
		public void UnPackTo(IElementalBoxStateTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601ED50 RID: 126288 RVA: 0x0045132C File Offset: 0x0044F52C
		public static Offset<IElementalBoxStateTarget> Pack(FlatBufferBuilder builder, IElementalBoxStateTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxStateTarget>);
			}
			return IElementalBoxStateTarget.CreateIElementalBoxStateTarget(builder, _o.Type);
		}

		// Token: 0x0400D599 RID: 54681
		private Table __p;
	}
}
