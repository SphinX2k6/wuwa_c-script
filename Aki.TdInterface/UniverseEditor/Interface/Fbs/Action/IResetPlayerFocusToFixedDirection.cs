using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007618 RID: 30232
	public struct IResetPlayerFocusToFixedDirection : IFlatbufferObject
	{
		// Token: 0x1700DE21 RID: 56865
		// (get) Token: 0x060350C3 RID: 217283 RVA: 0x007202AD File Offset: 0x0071E4AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060350C4 RID: 217284 RVA: 0x007202BA File Offset: 0x0071E4BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060350C5 RID: 217285 RVA: 0x007202C4 File Offset: 0x0071E4C4
		public static IResetPlayerFocusToFixedDirection GetRootAsIResetPlayerFocusToFixedDirection(ByteBuffer _bb)
		{
			return IResetPlayerFocusToFixedDirection.GetRootAsIResetPlayerFocusToFixedDirection(_bb, default(IResetPlayerFocusToFixedDirection));
		}

		// Token: 0x060350C6 RID: 217286 RVA: 0x007202E0 File Offset: 0x0071E4E0
		public static IResetPlayerFocusToFixedDirection GetRootAsIResetPlayerFocusToFixedDirection(ByteBuffer _bb, IResetPlayerFocusToFixedDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060350C7 RID: 217287 RVA: 0x007202FD File Offset: 0x0071E4FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060350C8 RID: 217288 RVA: 0x0072030C File Offset: 0x0071E50C
		public IResetPlayerFocusToFixedDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE22 RID: 56866
		// (get) Token: 0x060350C9 RID: 217289 RVA: 0x0072031C File Offset: 0x0071E51C
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

		// Token: 0x1700DE23 RID: 56867
		// (get) Token: 0x060350CA RID: 217290 RVA: 0x00720358 File Offset: 0x0071E558
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

		// Token: 0x060350CB RID: 217291 RVA: 0x007203B5 File Offset: 0x0071E5B5
		public static Offset<IResetPlayerFocusToFixedDirection> CreateIResetPlayerFocusToFixedDirection(FlatBufferBuilder builder, EResetPlayerFocusType Type = EResetPlayerFocusType.ResetToDefaultDirection, Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IResetPlayerFocusToFixedDirection.AddDirection(builder, DirectionOffset);
			IResetPlayerFocusToFixedDirection.AddType(builder, Type);
			return IResetPlayerFocusToFixedDirection.EndIResetPlayerFocusToFixedDirection(builder);
		}

		// Token: 0x060350CC RID: 217292 RVA: 0x007203D2 File Offset: 0x0071E5D2
		public static void StartIResetPlayerFocusToFixedDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060350CD RID: 217293 RVA: 0x007203DB File Offset: 0x0071E5DB
		public static void AddType(FlatBufferBuilder builder, EResetPlayerFocusType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060350CE RID: 217294 RVA: 0x007203E6 File Offset: 0x0071E5E6
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(1, directionOffset.Value, 0);
		}

		// Token: 0x060350CF RID: 217295 RVA: 0x007203F6 File Offset: 0x0071E5F6
		public static Offset<IResetPlayerFocusToFixedDirection> EndIResetPlayerFocusToFixedDirection(FlatBufferBuilder builder)
		{
			return new Offset<IResetPlayerFocusToFixedDirection>(builder.EndTable());
		}

		// Token: 0x060350D0 RID: 217296 RVA: 0x00720404 File Offset: 0x0071E604
		public IResetPlayerFocusToFixedDirectionT UnPack()
		{
			IResetPlayerFocusToFixedDirectionT resetPlayerFocusToFixedDirectionT = new IResetPlayerFocusToFixedDirectionT();
			this.UnPackTo(resetPlayerFocusToFixedDirectionT);
			return resetPlayerFocusToFixedDirectionT;
		}

		// Token: 0x060350D1 RID: 217297 RVA: 0x00720420 File Offset: 0x0071E620
		public void UnPackTo(IResetPlayerFocusToFixedDirectionT _o)
		{
			_o.Type = this.Type;
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
		}

		// Token: 0x060350D2 RID: 217298 RVA: 0x00720468 File Offset: 0x0071E668
		public static Offset<IResetPlayerFocusToFixedDirection> Pack(FlatBufferBuilder builder, IResetPlayerFocusToFixedDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPlayerFocusToFixedDirection>);
			}
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return IResetPlayerFocusToFixedDirection.CreateIResetPlayerFocusToFixedDirection(builder, _o.Type, directionOffset);
		}

		// Token: 0x04012807 RID: 75783
		private Table __p;
	}
}
