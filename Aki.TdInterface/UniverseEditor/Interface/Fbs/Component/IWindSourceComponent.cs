using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200619C RID: 24988
	public struct IWindSourceComponent : IFlatbufferObject
	{
		// Token: 0x1700BA56 RID: 47702
		// (get) Token: 0x0602A779 RID: 173945 RVA: 0x005CAEF2 File Offset: 0x005C90F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A77A RID: 173946 RVA: 0x005CAEFF File Offset: 0x005C90FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A77B RID: 173947 RVA: 0x005CAF08 File Offset: 0x005C9108
		public static IWindSourceComponent GetRootAsIWindSourceComponent(ByteBuffer _bb)
		{
			return IWindSourceComponent.GetRootAsIWindSourceComponent(_bb, default(IWindSourceComponent));
		}

		// Token: 0x0602A77C RID: 173948 RVA: 0x005CAF24 File Offset: 0x005C9124
		public static IWindSourceComponent GetRootAsIWindSourceComponent(ByteBuffer _bb, IWindSourceComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A77D RID: 173949 RVA: 0x005CAF41 File Offset: 0x005C9141
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A77E RID: 173950 RVA: 0x005CAF50 File Offset: 0x005C9150
		public IWindSourceComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA57 RID: 47703
		// (get) Token: 0x0602A77F RID: 173951 RVA: 0x005CAF60 File Offset: 0x005C9160
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BA58 RID: 47704
		// (get) Token: 0x0602A780 RID: 173952 RVA: 0x005CAFA0 File Offset: 0x005C91A0
		public IWindDirectional? WindSource
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IWindDirectional?(default(IWindDirectional).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BA59 RID: 47705
		// (get) Token: 0x0602A781 RID: 173953 RVA: 0x005CB000 File Offset: 0x005C9200
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A782 RID: 173954 RVA: 0x005CB03C File Offset: 0x005C923C
		public static Offset<IWindSourceComponent> CreateIWindSourceComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IWindDirectional> WindSourceOffset = default(Offset<IWindDirectional>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IWindSourceComponent.AddWindSource(builder, WindSourceOffset);
			IWindSourceComponent.AddNullMask(builder, NullMask);
			IWindSourceComponent.AddDisabled(builder, Disabled);
			return IWindSourceComponent.EndIWindSourceComponent(builder);
		}

		// Token: 0x0602A783 RID: 173955 RVA: 0x005CB060 File Offset: 0x005C9260
		public static void StartIWindSourceComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A784 RID: 173956 RVA: 0x005CB069 File Offset: 0x005C9269
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A785 RID: 173957 RVA: 0x005CB074 File Offset: 0x005C9274
		public static void AddWindSource(FlatBufferBuilder builder, Offset<IWindDirectional> windSourceOffset)
		{
			builder.AddOffset(1, windSourceOffset.Value, 0);
		}

		// Token: 0x0602A786 RID: 173958 RVA: 0x005CB084 File Offset: 0x005C9284
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A787 RID: 173959 RVA: 0x005CB08F File Offset: 0x005C928F
		public static Offset<IWindSourceComponent> EndIWindSourceComponent(FlatBufferBuilder builder)
		{
			return new Offset<IWindSourceComponent>(builder.EndTable());
		}

		// Token: 0x0602A788 RID: 173960 RVA: 0x005CB09C File Offset: 0x005C929C
		public IWindSourceComponentT UnPack()
		{
			IWindSourceComponentT windSourceComponentT = new IWindSourceComponentT();
			this.UnPackTo(windSourceComponentT);
			return windSourceComponentT;
		}

		// Token: 0x0602A789 RID: 173961 RVA: 0x005CB0B8 File Offset: 0x005C92B8
		public void UnPackTo(IWindSourceComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.WindSource = ((this.WindSource != null) ? this.WindSource.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A78A RID: 173962 RVA: 0x005CB10C File Offset: 0x005C930C
		public static Offset<IWindSourceComponent> Pack(FlatBufferBuilder builder, IWindSourceComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindSourceComponent>);
			}
			Offset<IWindDirectional> windSourceOffset = (_o.WindSource == null) ? default(Offset<IWindDirectional>) : IWindDirectional.Pack(builder, _o.WindSource);
			return IWindSourceComponent.CreateIWindSourceComponent(builder, _o.Disabled, windSourceOffset, _o.NullMask);
		}

		// Token: 0x0400FFE9 RID: 65513
		private Table __p;
	}
}
