using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E94 RID: 28308
	public struct IResetPlayerFocusToFixedDirection : IFlatbufferObject
	{
		// Token: 0x1700D2CA RID: 53962
		// (get) Token: 0x06032083 RID: 204931 RVA: 0x006C4579 File Offset: 0x006C2779
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032084 RID: 204932 RVA: 0x006C4586 File Offset: 0x006C2786
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032085 RID: 204933 RVA: 0x006C4590 File Offset: 0x006C2790
		public static IResetPlayerFocusToFixedDirection GetRootAsIResetPlayerFocusToFixedDirection(ByteBuffer _bb)
		{
			return IResetPlayerFocusToFixedDirection.GetRootAsIResetPlayerFocusToFixedDirection(_bb, default(IResetPlayerFocusToFixedDirection));
		}

		// Token: 0x06032086 RID: 204934 RVA: 0x006C45AC File Offset: 0x006C27AC
		public static IResetPlayerFocusToFixedDirection GetRootAsIResetPlayerFocusToFixedDirection(ByteBuffer _bb, IResetPlayerFocusToFixedDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032087 RID: 204935 RVA: 0x006C45C9 File Offset: 0x006C27C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032088 RID: 204936 RVA: 0x006C45D8 File Offset: 0x006C27D8
		public IResetPlayerFocusToFixedDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2CB RID: 53963
		// (get) Token: 0x06032089 RID: 204937 RVA: 0x006C45E8 File Offset: 0x006C27E8
		public EResetPlayerFocusType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetPlayerFocusType.ResetToDefaultDirection;
				}
				return (EResetPlayerFocusType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D2CC RID: 53964
		// (get) Token: 0x0603208A RID: 204938 RVA: 0x006C4624 File Offset: 0x006C2824
		public IVectorInfo? Direction
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

		// Token: 0x0603208B RID: 204939 RVA: 0x006C4681 File Offset: 0x006C2881
		public static Offset<IResetPlayerFocusToFixedDirection> CreateIResetPlayerFocusToFixedDirection(FlatBufferBuilder builder, EResetPlayerFocusType Type = EResetPlayerFocusType.ResetToDefaultDirection, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IResetPlayerFocusToFixedDirection.AddDirection(builder, DirectionOffset);
			IResetPlayerFocusToFixedDirection.AddType(builder, Type);
			return IResetPlayerFocusToFixedDirection.EndIResetPlayerFocusToFixedDirection(builder);
		}

		// Token: 0x0603208C RID: 204940 RVA: 0x006C469E File Offset: 0x006C289E
		public static void StartIResetPlayerFocusToFixedDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603208D RID: 204941 RVA: 0x006C46A7 File Offset: 0x006C28A7
		public static void AddType(FlatBufferBuilder builder, EResetPlayerFocusType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603208E RID: 204942 RVA: 0x006C46B2 File Offset: 0x006C28B2
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(1, directionOffset.Value, 0);
		}

		// Token: 0x0603208F RID: 204943 RVA: 0x006C46C2 File Offset: 0x006C28C2
		public static Offset<IResetPlayerFocusToFixedDirection> EndIResetPlayerFocusToFixedDirection(FlatBufferBuilder builder)
		{
			return new Offset<IResetPlayerFocusToFixedDirection>(builder.EndTable());
		}

		// Token: 0x06032090 RID: 204944 RVA: 0x006C46D0 File Offset: 0x006C28D0
		public IResetPlayerFocusToFixedDirectionT UnPack()
		{
			IResetPlayerFocusToFixedDirectionT resetPlayerFocusToFixedDirectionT = new IResetPlayerFocusToFixedDirectionT();
			this.UnPackTo(resetPlayerFocusToFixedDirectionT);
			return resetPlayerFocusToFixedDirectionT;
		}

		// Token: 0x06032091 RID: 204945 RVA: 0x006C46EC File Offset: 0x006C28EC
		public void UnPackTo(IResetPlayerFocusToFixedDirectionT _o)
		{
			_o.Type = this.Type;
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
		}

		// Token: 0x06032092 RID: 204946 RVA: 0x006C4734 File Offset: 0x006C2934
		public static Offset<IResetPlayerFocusToFixedDirection> Pack(FlatBufferBuilder builder, IResetPlayerFocusToFixedDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPlayerFocusToFixedDirection>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return IResetPlayerFocusToFixedDirection.CreateIResetPlayerFocusToFixedDirection(builder, _o.Type, directionOffset);
		}

		// Token: 0x04011882 RID: 71810
		private Table __p;
	}
}
