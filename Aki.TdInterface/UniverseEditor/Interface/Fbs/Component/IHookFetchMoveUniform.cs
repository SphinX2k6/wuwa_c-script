using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005942 RID: 22850
	public struct IHookFetchMoveUniform : IFlatbufferObject
	{
		// Token: 0x1700A5C4 RID: 42436
		// (get) Token: 0x060252BE RID: 152254 RVA: 0x00519C2E File Offset: 0x00517E2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060252BF RID: 152255 RVA: 0x00519C3B File Offset: 0x00517E3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060252C0 RID: 152256 RVA: 0x00519C44 File Offset: 0x00517E44
		public static IHookFetchMoveUniform GetRootAsIHookFetchMoveUniform(ByteBuffer _bb)
		{
			return IHookFetchMoveUniform.GetRootAsIHookFetchMoveUniform(_bb, default(IHookFetchMoveUniform));
		}

		// Token: 0x060252C1 RID: 152257 RVA: 0x00519C60 File Offset: 0x00517E60
		public static IHookFetchMoveUniform GetRootAsIHookFetchMoveUniform(ByteBuffer _bb, IHookFetchMoveUniform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060252C2 RID: 152258 RVA: 0x00519C7D File Offset: 0x00517E7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060252C3 RID: 152259 RVA: 0x00519C8C File Offset: 0x00517E8C
		public IHookFetchMoveUniform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5C5 RID: 42437
		// (get) Token: 0x060252C4 RID: 152260 RVA: 0x00519C9C File Offset: 0x00517E9C
		public EHookFetchMoveMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHookFetchMoveMode.Uniform;
				}
				return (EHookFetchMoveMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A5C6 RID: 42438
		// (get) Token: 0x060252C5 RID: 152261 RVA: 0x00519CD8 File Offset: 0x00517ED8
		public float Speed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060252C6 RID: 152262 RVA: 0x00519D18 File Offset: 0x00517F18
		public static Offset<IHookFetchMoveUniform> CreateIHookFetchMoveUniform(FlatBufferBuilder builder, EHookFetchMoveMode Type = EHookFetchMoveMode.Uniform, float Speed = 0f)
		{
			builder.StartTable(2);
			IHookFetchMoveUniform.AddSpeed(builder, Speed);
			IHookFetchMoveUniform.AddType(builder, Type);
			return IHookFetchMoveUniform.EndIHookFetchMoveUniform(builder);
		}

		// Token: 0x060252C7 RID: 152263 RVA: 0x00519D35 File Offset: 0x00517F35
		public static void StartIHookFetchMoveUniform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060252C8 RID: 152264 RVA: 0x00519D3E File Offset: 0x00517F3E
		public static void AddType(FlatBufferBuilder builder, EHookFetchMoveMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060252C9 RID: 152265 RVA: 0x00519D49 File Offset: 0x00517F49
		public static void AddSpeed(FlatBufferBuilder builder, float speed)
		{
			builder.AddFloat(1, speed, 0.0);
		}

		// Token: 0x060252CA RID: 152266 RVA: 0x00519D5C File Offset: 0x00517F5C
		public static Offset<IHookFetchMoveUniform> EndIHookFetchMoveUniform(FlatBufferBuilder builder)
		{
			return new Offset<IHookFetchMoveUniform>(builder.EndTable());
		}

		// Token: 0x060252CB RID: 152267 RVA: 0x00519D6C File Offset: 0x00517F6C
		public IHookFetchMoveUniformT UnPack()
		{
			IHookFetchMoveUniformT hookFetchMoveUniformT = new IHookFetchMoveUniformT();
			this.UnPackTo(hookFetchMoveUniformT);
			return hookFetchMoveUniformT;
		}

		// Token: 0x060252CC RID: 152268 RVA: 0x00519D87 File Offset: 0x00517F87
		public void UnPackTo(IHookFetchMoveUniformT _o)
		{
			_o.Type = this.Type;
			_o.Speed = this.Speed;
		}

		// Token: 0x060252CD RID: 152269 RVA: 0x00519DA4 File Offset: 0x00517FA4
		public static Offset<IHookFetchMoveUniform> Pack(FlatBufferBuilder builder, IHookFetchMoveUniformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookFetchMoveUniform>);
			}
			return IHookFetchMoveUniform.CreateIHookFetchMoveUniform(builder, _o.Type, _o.Speed);
		}

		// Token: 0x0400F1EE RID: 61934
		private Table __p;
	}
}
