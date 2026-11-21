using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EED RID: 28397
	public struct IFoxAutoJump : IFlatbufferObject
	{
		// Token: 0x1700D038 RID: 53304
		// (get) Token: 0x06031215 RID: 201237 RVA: 0x006A901D File Offset: 0x006A721D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031216 RID: 201238 RVA: 0x006A902A File Offset: 0x006A722A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031217 RID: 201239 RVA: 0x006A9034 File Offset: 0x006A7234
		public static IFoxAutoJump GetRootAsIFoxAutoJump(ByteBuffer _bb)
		{
			return IFoxAutoJump.GetRootAsIFoxAutoJump(_bb, default(IFoxAutoJump));
		}

		// Token: 0x06031218 RID: 201240 RVA: 0x006A9050 File Offset: 0x006A7250
		public static IFoxAutoJump GetRootAsIFoxAutoJump(ByteBuffer _bb, IFoxAutoJump obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031219 RID: 201241 RVA: 0x006A906D File Offset: 0x006A726D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603121A RID: 201242 RVA: 0x006A907C File Offset: 0x006A727C
		public IFoxAutoJump __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D039 RID: 53305
		// (get) Token: 0x0603121B RID: 201243 RVA: 0x006A908C File Offset: 0x006A728C
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D03A RID: 53306
		// (get) Token: 0x0603121C RID: 201244 RVA: 0x006A90C8 File Offset: 0x006A72C8
		public IVectorInfo? LandPosition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603121D RID: 201245 RVA: 0x006A9125 File Offset: 0x006A7325
		public static Offset<IFoxAutoJump> CreateIFoxAutoJump(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, Offset<IVectorInfo> LandPositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IFoxAutoJump.AddLandPosition(builder, LandPositionOffset);
			IFoxAutoJump.AddType(builder, Type);
			return IFoxAutoJump.EndIFoxAutoJump(builder);
		}

		// Token: 0x0603121E RID: 201246 RVA: 0x006A9142 File Offset: 0x006A7342
		public static void StartIFoxAutoJump(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603121F RID: 201247 RVA: 0x006A914B File Offset: 0x006A734B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031220 RID: 201248 RVA: 0x006A9156 File Offset: 0x006A7356
		public static void AddLandPosition(FlatBufferBuilder builder, Offset<IVectorInfo> landPositionOffset)
		{
			builder.AddOffset(1, landPositionOffset.Value, 0);
		}

		// Token: 0x06031221 RID: 201249 RVA: 0x006A9166 File Offset: 0x006A7366
		public static Offset<IFoxAutoJump> EndIFoxAutoJump(FlatBufferBuilder builder)
		{
			return new Offset<IFoxAutoJump>(builder.EndTable());
		}

		// Token: 0x06031222 RID: 201250 RVA: 0x006A9174 File Offset: 0x006A7374
		public IFoxAutoJumpT UnPack()
		{
			IFoxAutoJumpT foxAutoJumpT = new IFoxAutoJumpT();
			this.UnPackTo(foxAutoJumpT);
			return foxAutoJumpT;
		}

		// Token: 0x06031223 RID: 201251 RVA: 0x006A9190 File Offset: 0x006A7390
		public void UnPackTo(IFoxAutoJumpT _o)
		{
			_o.Type = this.Type;
			_o.LandPosition = ((this.LandPosition != null) ? this.LandPosition.Value.UnPack() : null);
		}

		// Token: 0x06031224 RID: 201252 RVA: 0x006A91D8 File Offset: 0x006A73D8
		public static Offset<IFoxAutoJump> Pack(FlatBufferBuilder builder, IFoxAutoJumpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxAutoJump>);
			}
			Offset<IVectorInfo> landPositionOffset = (_o.LandPosition == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LandPosition);
			return IFoxAutoJump.CreateIFoxAutoJump(builder, _o.Type, landPositionOffset);
		}

		// Token: 0x04011DED RID: 73197
		private Table __p;
	}
}
