using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200547F RID: 21631
	public struct IInteractStylePanorama : IFlatbufferObject
	{
		// Token: 0x17009F34 RID: 40756
		// (get) Token: 0x06023957 RID: 145751 RVA: 0x004EBA68 File Offset: 0x004E9C68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023958 RID: 145752 RVA: 0x004EBA75 File Offset: 0x004E9C75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023959 RID: 145753 RVA: 0x004EBA7C File Offset: 0x004E9C7C
		public static IInteractStylePanorama GetRootAsIInteractStylePanorama(ByteBuffer _bb)
		{
			return IInteractStylePanorama.GetRootAsIInteractStylePanorama(_bb, default(IInteractStylePanorama));
		}

		// Token: 0x0602395A RID: 145754 RVA: 0x004EBA98 File Offset: 0x004E9C98
		public static IInteractStylePanorama GetRootAsIInteractStylePanorama(ByteBuffer _bb, IInteractStylePanorama obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602395B RID: 145755 RVA: 0x004EBAB5 File Offset: 0x004E9CB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602395C RID: 145756 RVA: 0x004EBAC4 File Offset: 0x004E9CC4
		public IInteractStylePanorama __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F35 RID: 40757
		// (get) Token: 0x0602395D RID: 145757 RVA: 0x004EBAD4 File Offset: 0x004E9CD4
		public EInteractStyleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractStyleType.Panorama;
				}
				return (EInteractStyleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F36 RID: 40758
		// (get) Token: 0x0602395E RID: 145758 RVA: 0x004EBB10 File Offset: 0x004E9D10
		public IVectorInfo? TargetPos
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

		// Token: 0x17009F37 RID: 40759
		// (get) Token: 0x0602395F RID: 145759 RVA: 0x004EBB70 File Offset: 0x004E9D70
		public int TriggerRange
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F38 RID: 40760
		// (get) Token: 0x06023960 RID: 145760 RVA: 0x004EBBAC File Offset: 0x004E9DAC
		public int TriggerAngle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F39 RID: 40761
		// (get) Token: 0x06023961 RID: 145761 RVA: 0x004EBBEC File Offset: 0x004E9DEC
		public int ProtectRange
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F3A RID: 40762
		// (get) Token: 0x06023962 RID: 145762 RVA: 0x004EBC2C File Offset: 0x004E9E2C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023963 RID: 145763 RVA: 0x004EBC69 File Offset: 0x004E9E69
		public static Offset<IInteractStylePanorama> CreateIInteractStylePanorama(FlatBufferBuilder builder, EInteractStyleType Type = EInteractStyleType.Panorama, Offset<IVectorInfo> TargetPosOffset = default(Offset<IVectorInfo>), int TriggerRange = 0, int TriggerAngle = 0, int ProtectRange = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IInteractStylePanorama.AddProtectRange(builder, ProtectRange);
			IInteractStylePanorama.AddTriggerAngle(builder, TriggerAngle);
			IInteractStylePanorama.AddTriggerRange(builder, TriggerRange);
			IInteractStylePanorama.AddTargetPos(builder, TargetPosOffset);
			IInteractStylePanorama.AddNullMask(builder, NullMask);
			IInteractStylePanorama.AddType(builder, Type);
			return IInteractStylePanorama.EndIInteractStylePanorama(builder);
		}

		// Token: 0x06023964 RID: 145764 RVA: 0x004EBCA5 File Offset: 0x004E9EA5
		public static void StartIInteractStylePanorama(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06023965 RID: 145765 RVA: 0x004EBCAE File Offset: 0x004E9EAE
		public static void AddType(FlatBufferBuilder builder, EInteractStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023966 RID: 145766 RVA: 0x004EBCB9 File Offset: 0x004E9EB9
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IVectorInfo> targetPosOffset)
		{
			builder.AddOffset(1, targetPosOffset.Value, 0);
		}

		// Token: 0x06023967 RID: 145767 RVA: 0x004EBCC9 File Offset: 0x004E9EC9
		public static void AddTriggerRange(FlatBufferBuilder builder, int triggerRange)
		{
			builder.AddInt(2, triggerRange, 0);
		}

		// Token: 0x06023968 RID: 145768 RVA: 0x004EBCD4 File Offset: 0x004E9ED4
		public static void AddTriggerAngle(FlatBufferBuilder builder, int triggerAngle)
		{
			builder.AddInt(3, triggerAngle, 0);
		}

		// Token: 0x06023969 RID: 145769 RVA: 0x004EBCDF File Offset: 0x004E9EDF
		public static void AddProtectRange(FlatBufferBuilder builder, int protectRange)
		{
			builder.AddInt(4, protectRange, 0);
		}

		// Token: 0x0602396A RID: 145770 RVA: 0x004EBCEA File Offset: 0x004E9EEA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602396B RID: 145771 RVA: 0x004EBCF5 File Offset: 0x004E9EF5
		public static Offset<IInteractStylePanorama> EndIInteractStylePanorama(FlatBufferBuilder builder)
		{
			return new Offset<IInteractStylePanorama>(builder.EndTable());
		}

		// Token: 0x0602396C RID: 145772 RVA: 0x004EBD04 File Offset: 0x004E9F04
		public IInteractStylePanoramaT UnPack()
		{
			IInteractStylePanoramaT interactStylePanoramaT = new IInteractStylePanoramaT();
			this.UnPackTo(interactStylePanoramaT);
			return interactStylePanoramaT;
		}

		// Token: 0x0602396D RID: 145773 RVA: 0x004EBD20 File Offset: 0x004E9F20
		public void UnPackTo(IInteractStylePanoramaT _o)
		{
			_o.Type = this.Type;
			_o.TargetPos = ((this.TargetPos != null) ? this.TargetPos.Value.UnPack() : null);
			_o.TriggerRange = this.TriggerRange;
			_o.TriggerAngle = this.TriggerAngle;
			_o.ProtectRange = this.ProtectRange;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602396E RID: 145774 RVA: 0x004EBD98 File Offset: 0x004E9F98
		public static Offset<IInteractStylePanorama> Pack(FlatBufferBuilder builder, IInteractStylePanoramaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractStylePanorama>);
			}
			Offset<IVectorInfo> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TargetPos);
			return IInteractStylePanorama.CreateIInteractStylePanorama(builder, _o.Type, targetPosOffset, _o.TriggerRange, _o.TriggerAngle, _o.ProtectRange, _o.NullMask);
		}

		// Token: 0x0400E702 RID: 59138
		private Table __p;
	}
}
