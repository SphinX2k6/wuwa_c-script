using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EA2 RID: 20130
	public struct ICheckElementalEffectActive : IFlatbufferObject
	{
		// Token: 0x17008F99 RID: 36761
		// (get) Token: 0x0601F32D RID: 127789 RVA: 0x00459A30 File Offset: 0x00457C30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F32E RID: 127790 RVA: 0x00459A3D File Offset: 0x00457C3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F32F RID: 127791 RVA: 0x00459A44 File Offset: 0x00457C44
		public static ICheckElementalEffectActive GetRootAsICheckElementalEffectActive(ByteBuffer _bb)
		{
			return ICheckElementalEffectActive.GetRootAsICheckElementalEffectActive(_bb, default(ICheckElementalEffectActive));
		}

		// Token: 0x0601F330 RID: 127792 RVA: 0x00459A60 File Offset: 0x00457C60
		public static ICheckElementalEffectActive GetRootAsICheckElementalEffectActive(ByteBuffer _bb, ICheckElementalEffectActive obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F331 RID: 127793 RVA: 0x00459A7D File Offset: 0x00457C7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F332 RID: 127794 RVA: 0x00459A8C File Offset: 0x00457C8C
		public ICheckElementalEffectActive __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F9A RID: 36762
		// (get) Token: 0x0601F333 RID: 127795 RVA: 0x00459A9C File Offset: 0x00457C9C
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

		// Token: 0x17008F9B RID: 36763
		// (get) Token: 0x0601F334 RID: 127796 RVA: 0x00459AD8 File Offset: 0x00457CD8
		public bool IsActive
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F335 RID: 127797 RVA: 0x00459B17 File Offset: 0x00457D17
		public static Offset<ICheckElementalEffectActive> CreateICheckElementalEffectActive(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsActive = false)
		{
			builder.StartTable(2);
			ICheckElementalEffectActive.AddIsActive(builder, IsActive);
			ICheckElementalEffectActive.AddType(builder, Type);
			return ICheckElementalEffectActive.EndICheckElementalEffectActive(builder);
		}

		// Token: 0x0601F336 RID: 127798 RVA: 0x00459B34 File Offset: 0x00457D34
		public static void StartICheckElementalEffectActive(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F337 RID: 127799 RVA: 0x00459B3D File Offset: 0x00457D3D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F338 RID: 127800 RVA: 0x00459B48 File Offset: 0x00457D48
		public static void AddIsActive(FlatBufferBuilder builder, bool isActive)
		{
			builder.AddBool(1, isActive, false);
		}

		// Token: 0x0601F339 RID: 127801 RVA: 0x00459B53 File Offset: 0x00457D53
		public static Offset<ICheckElementalEffectActive> EndICheckElementalEffectActive(FlatBufferBuilder builder)
		{
			return new Offset<ICheckElementalEffectActive>(builder.EndTable());
		}

		// Token: 0x0601F33A RID: 127802 RVA: 0x00459B60 File Offset: 0x00457D60
		public ICheckElementalEffectActiveT UnPack()
		{
			ICheckElementalEffectActiveT checkElementalEffectActiveT = new ICheckElementalEffectActiveT();
			this.UnPackTo(checkElementalEffectActiveT);
			return checkElementalEffectActiveT;
		}

		// Token: 0x0601F33B RID: 127803 RVA: 0x00459B7B File Offset: 0x00457D7B
		public void UnPackTo(ICheckElementalEffectActiveT _o)
		{
			_o.Type = this.Type;
			_o.IsActive = this.IsActive;
		}

		// Token: 0x0601F33C RID: 127804 RVA: 0x00459B98 File Offset: 0x00457D98
		public static Offset<ICheckElementalEffectActive> Pack(FlatBufferBuilder builder, ICheckElementalEffectActiveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckElementalEffectActive>);
			}
			return ICheckElementalEffectActive.CreateICheckElementalEffectActive(builder, _o.Type, _o.IsActive);
		}

		// Token: 0x0400DCE6 RID: 56550
		private Table __p;
	}
}
