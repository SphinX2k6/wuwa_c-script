using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE8 RID: 27624
	public struct INpcSwingGetUp : IFlatbufferObject
	{
		// Token: 0x1700CD52 RID: 52562
		// (get) Token: 0x0603089A RID: 198810 RVA: 0x00696D64 File Offset: 0x00694F64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603089B RID: 198811 RVA: 0x00696D71 File Offset: 0x00694F71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603089C RID: 198812 RVA: 0x00696D78 File Offset: 0x00694F78
		public static INpcSwingGetUp GetRootAsINpcSwingGetUp(ByteBuffer _bb)
		{
			return INpcSwingGetUp.GetRootAsINpcSwingGetUp(_bb, default(INpcSwingGetUp));
		}

		// Token: 0x0603089D RID: 198813 RVA: 0x00696D94 File Offset: 0x00694F94
		public static INpcSwingGetUp GetRootAsINpcSwingGetUp(ByteBuffer _bb, INpcSwingGetUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603089E RID: 198814 RVA: 0x00696DB1 File Offset: 0x00694FB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603089F RID: 198815 RVA: 0x00696DC0 File Offset: 0x00694FC0
		public INpcSwingGetUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD53 RID: 52563
		// (get) Token: 0x060308A0 RID: 198816 RVA: 0x00696DD0 File Offset: 0x00694FD0
		public ENpcLeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcLeisureInteract.SitDown;
				}
				return (ENpcLeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD54 RID: 52564
		// (get) Token: 0x060308A1 RID: 198817 RVA: 0x00696E0C File Offset: 0x0069500C
		public bool KeepState
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CD55 RID: 52565
		// (get) Token: 0x060308A2 RID: 198818 RVA: 0x00696E4C File Offset: 0x0069504C
		public int TargetNpcId
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

		// Token: 0x1700CD56 RID: 52566
		// (get) Token: 0x060308A3 RID: 198819 RVA: 0x00696E88 File Offset: 0x00695088
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060308A4 RID: 198820 RVA: 0x00696EC5 File Offset: 0x006950C5
		public static Offset<INpcSwingGetUp> CreateINpcSwingGetUp(FlatBufferBuilder builder, ENpcLeisureInteract Type = ENpcLeisureInteract.SitDown, bool KeepState = false, int TargetNpcId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			INpcSwingGetUp.AddTargetNpcId(builder, TargetNpcId);
			INpcSwingGetUp.AddNullMask(builder, NullMask);
			INpcSwingGetUp.AddKeepState(builder, KeepState);
			INpcSwingGetUp.AddType(builder, Type);
			return INpcSwingGetUp.EndINpcSwingGetUp(builder);
		}

		// Token: 0x060308A5 RID: 198821 RVA: 0x00696EF1 File Offset: 0x006950F1
		public static void StartINpcSwingGetUp(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060308A6 RID: 198822 RVA: 0x00696EFA File Offset: 0x006950FA
		public static void AddType(FlatBufferBuilder builder, ENpcLeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060308A7 RID: 198823 RVA: 0x00696F05 File Offset: 0x00695105
		public static void AddKeepState(FlatBufferBuilder builder, bool keepState)
		{
			builder.AddBool(1, keepState, false);
		}

		// Token: 0x060308A8 RID: 198824 RVA: 0x00696F10 File Offset: 0x00695110
		public static void AddTargetNpcId(FlatBufferBuilder builder, int targetNpcId)
		{
			builder.AddInt(2, targetNpcId, 0);
		}

		// Token: 0x060308A9 RID: 198825 RVA: 0x00696F1B File Offset: 0x0069511B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060308AA RID: 198826 RVA: 0x00696F26 File Offset: 0x00695126
		public static Offset<INpcSwingGetUp> EndINpcSwingGetUp(FlatBufferBuilder builder)
		{
			return new Offset<INpcSwingGetUp>(builder.EndTable());
		}

		// Token: 0x060308AB RID: 198827 RVA: 0x00696F34 File Offset: 0x00695134
		public INpcSwingGetUpT UnPack()
		{
			INpcSwingGetUpT npcSwingGetUpT = new INpcSwingGetUpT();
			this.UnPackTo(npcSwingGetUpT);
			return npcSwingGetUpT;
		}

		// Token: 0x060308AC RID: 198828 RVA: 0x00696F4F File Offset: 0x0069514F
		public void UnPackTo(INpcSwingGetUpT _o)
		{
			_o.Type = this.Type;
			_o.KeepState = this.KeepState;
			_o.TargetNpcId = this.TargetNpcId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060308AD RID: 198829 RVA: 0x00696F84 File Offset: 0x00695184
		public static Offset<INpcSwingGetUp> Pack(FlatBufferBuilder builder, INpcSwingGetUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcSwingGetUp>);
			}
			return INpcSwingGetUp.CreateINpcSwingGetUp(builder, _o.Type, _o.KeepState, _o.TargetNpcId, _o.NullMask);
		}

		// Token: 0x040114D5 RID: 70869
		private Table __p;
	}
}
