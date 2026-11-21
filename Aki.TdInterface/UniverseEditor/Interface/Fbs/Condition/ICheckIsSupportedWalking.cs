using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F6B RID: 20331
	public struct ICheckIsSupportedWalking : IFlatbufferObject
	{
		// Token: 0x17009151 RID: 37201
		// (get) Token: 0x0601FA4D RID: 129613 RVA: 0x00466734 File Offset: 0x00464934
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FA4E RID: 129614 RVA: 0x00466741 File Offset: 0x00464941
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FA4F RID: 129615 RVA: 0x00466748 File Offset: 0x00464948
		public static ICheckIsSupportedWalking GetRootAsICheckIsSupportedWalking(ByteBuffer _bb)
		{
			return ICheckIsSupportedWalking.GetRootAsICheckIsSupportedWalking(_bb, default(ICheckIsSupportedWalking));
		}

		// Token: 0x0601FA50 RID: 129616 RVA: 0x00466764 File Offset: 0x00464964
		public static ICheckIsSupportedWalking GetRootAsICheckIsSupportedWalking(ByteBuffer _bb, ICheckIsSupportedWalking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FA51 RID: 129617 RVA: 0x00466781 File Offset: 0x00464981
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FA52 RID: 129618 RVA: 0x00466790 File Offset: 0x00464990
		public ICheckIsSupportedWalking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009152 RID: 37202
		// (get) Token: 0x0601FA53 RID: 129619 RVA: 0x004667A0 File Offset: 0x004649A0
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009153 RID: 37203
		// (get) Token: 0x0601FA54 RID: 129620 RVA: 0x004667DC File Offset: 0x004649DC
		public bool IsSupported
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FA55 RID: 129621 RVA: 0x0046681B File Offset: 0x00464A1B
		public static Offset<ICheckIsSupportedWalking> CreateICheckIsSupportedWalking(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsSupported = false)
		{
			builder.StartTable(2);
			ICheckIsSupportedWalking.AddIsSupported(builder, IsSupported);
			ICheckIsSupportedWalking.AddType(builder, Type);
			return ICheckIsSupportedWalking.EndICheckIsSupportedWalking(builder);
		}

		// Token: 0x0601FA56 RID: 129622 RVA: 0x00466838 File Offset: 0x00464A38
		public static void StartICheckIsSupportedWalking(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FA57 RID: 129623 RVA: 0x00466841 File Offset: 0x00464A41
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FA58 RID: 129624 RVA: 0x0046684C File Offset: 0x00464A4C
		public static void AddIsSupported(FlatBufferBuilder builder, bool isSupported)
		{
			builder.AddBool(1, isSupported, false);
		}

		// Token: 0x0601FA59 RID: 129625 RVA: 0x00466857 File Offset: 0x00464A57
		public static Offset<ICheckIsSupportedWalking> EndICheckIsSupportedWalking(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsSupportedWalking>(builder.EndTable());
		}

		// Token: 0x0601FA5A RID: 129626 RVA: 0x00466864 File Offset: 0x00464A64
		public ICheckIsSupportedWalkingT UnPack()
		{
			ICheckIsSupportedWalkingT checkIsSupportedWalkingT = new ICheckIsSupportedWalkingT();
			this.UnPackTo(checkIsSupportedWalkingT);
			return checkIsSupportedWalkingT;
		}

		// Token: 0x0601FA5B RID: 129627 RVA: 0x0046687F File Offset: 0x00464A7F
		public void UnPackTo(ICheckIsSupportedWalkingT _o)
		{
			_o.Type = this.Type;
			_o.IsSupported = this.IsSupported;
		}

		// Token: 0x0601FA5C RID: 129628 RVA: 0x0046689C File Offset: 0x00464A9C
		public static Offset<ICheckIsSupportedWalking> Pack(FlatBufferBuilder builder, ICheckIsSupportedWalkingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsSupportedWalking>);
			}
			return ICheckIsSupportedWalking.CreateICheckIsSupportedWalking(builder, _o.Type, _o.IsSupported);
		}

		// Token: 0x0400DDF4 RID: 56820
		private Table __p;
	}
}
