using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD2 RID: 23762
	public struct IPasserbyNpcStandPos : IFlatbufferObject
	{
		// Token: 0x1700AE9A RID: 44698
		// (get) Token: 0x06027717 RID: 161559 RVA: 0x00566058 File Offset: 0x00564258
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027718 RID: 161560 RVA: 0x00566065 File Offset: 0x00564265
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027719 RID: 161561 RVA: 0x0056606C File Offset: 0x0056426C
		public static IPasserbyNpcStandPos GetRootAsIPasserbyNpcStandPos(ByteBuffer _bb)
		{
			return IPasserbyNpcStandPos.GetRootAsIPasserbyNpcStandPos(_bb, default(IPasserbyNpcStandPos));
		}

		// Token: 0x0602771A RID: 161562 RVA: 0x00566088 File Offset: 0x00564288
		public static IPasserbyNpcStandPos GetRootAsIPasserbyNpcStandPos(ByteBuffer _bb, IPasserbyNpcStandPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602771B RID: 161563 RVA: 0x005660A5 File Offset: 0x005642A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602771C RID: 161564 RVA: 0x005660B4 File Offset: 0x005642B4
		public IPasserbyNpcStandPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE9B RID: 44699
		// (get) Token: 0x0602771D RID: 161565 RVA: 0x005660C4 File Offset: 0x005642C4
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AE9C RID: 44700
		// (get) Token: 0x0602771E RID: 161566 RVA: 0x00566124 File Offset: 0x00564324
		public int Yaw
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602771F RID: 161567 RVA: 0x00566160 File Offset: 0x00564360
		public static Offset<IPasserbyNpcStandPos> CreateIPasserbyNpcStandPos(FlatBufferBuilder builder, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), int Yaw = 0)
		{
			builder.StartTable(2);
			IPasserbyNpcStandPos.AddYaw(builder, Yaw);
			IPasserbyNpcStandPos.AddOffset(builder, OffsetOffset);
			return IPasserbyNpcStandPos.EndIPasserbyNpcStandPos(builder);
		}

		// Token: 0x06027720 RID: 161568 RVA: 0x0056617D File Offset: 0x0056437D
		public static void StartIPasserbyNpcStandPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027721 RID: 161569 RVA: 0x00566186 File Offset: 0x00564386
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(0, offsetOffset.Value, 0);
		}

		// Token: 0x06027722 RID: 161570 RVA: 0x00566196 File Offset: 0x00564396
		public static void AddYaw(FlatBufferBuilder builder, int yaw)
		{
			builder.AddInt(1, yaw, 0);
		}

		// Token: 0x06027723 RID: 161571 RVA: 0x005661A1 File Offset: 0x005643A1
		public static Offset<IPasserbyNpcStandPos> EndIPasserbyNpcStandPos(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcStandPos>(builder.EndTable());
		}

		// Token: 0x06027724 RID: 161572 RVA: 0x005661B0 File Offset: 0x005643B0
		public IPasserbyNpcStandPosT UnPack()
		{
			IPasserbyNpcStandPosT passerbyNpcStandPosT = new IPasserbyNpcStandPosT();
			this.UnPackTo(passerbyNpcStandPosT);
			return passerbyNpcStandPosT;
		}

		// Token: 0x06027725 RID: 161573 RVA: 0x005661CC File Offset: 0x005643CC
		public void UnPackTo(IPasserbyNpcStandPosT _o)
		{
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.Yaw = this.Yaw;
		}

		// Token: 0x06027726 RID: 161574 RVA: 0x00566214 File Offset: 0x00564414
		public static Offset<IPasserbyNpcStandPos> Pack(FlatBufferBuilder builder, IPasserbyNpcStandPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcStandPos>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IPasserbyNpcStandPos.CreateIPasserbyNpcStandPos(builder, offsetOffset, _o.Yaw);
		}

		// Token: 0x0400F800 RID: 63488
		private Table __p;
	}
}
