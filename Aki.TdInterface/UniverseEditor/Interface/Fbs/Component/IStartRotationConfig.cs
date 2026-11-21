using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FA5 RID: 24485
	public struct IStartRotationConfig : IFlatbufferObject
	{
		// Token: 0x1700B552 RID: 46418
		// (get) Token: 0x060292E8 RID: 168680 RVA: 0x0059F53A File Offset: 0x0059D73A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060292E9 RID: 168681 RVA: 0x0059F547 File Offset: 0x0059D747
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060292EA RID: 168682 RVA: 0x0059F550 File Offset: 0x0059D750
		public static IStartRotationConfig GetRootAsIStartRotationConfig(ByteBuffer _bb)
		{
			return IStartRotationConfig.GetRootAsIStartRotationConfig(_bb, default(IStartRotationConfig));
		}

		// Token: 0x060292EB RID: 168683 RVA: 0x0059F56C File Offset: 0x0059D76C
		public static IStartRotationConfig GetRootAsIStartRotationConfig(ByteBuffer _bb, IStartRotationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060292EC RID: 168684 RVA: 0x0059F589 File Offset: 0x0059D789
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060292ED RID: 168685 RVA: 0x0059F598 File Offset: 0x0059D798
		public IStartRotationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B553 RID: 46419
		// (get) Token: 0x060292EE RID: 168686 RVA: 0x0059F5A8 File Offset: 0x0059D7A8
		public IVectorInfo? TargetRotation
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

		// Token: 0x1700B554 RID: 46420
		// (get) Token: 0x060292EF RID: 168687 RVA: 0x0059F608 File Offset: 0x0059D808
		public float AngularSpeed
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

		// Token: 0x060292F0 RID: 168688 RVA: 0x0059F648 File Offset: 0x0059D848
		public static Offset<IStartRotationConfig> CreateIStartRotationConfig(FlatBufferBuilder builder, Offset<IVectorInfo> TargetRotationOffset = default(Offset<IVectorInfo>), float AngularSpeed = 0f)
		{
			builder.StartTable(2);
			IStartRotationConfig.AddAngularSpeed(builder, AngularSpeed);
			IStartRotationConfig.AddTargetRotation(builder, TargetRotationOffset);
			return IStartRotationConfig.EndIStartRotationConfig(builder);
		}

		// Token: 0x060292F1 RID: 168689 RVA: 0x0059F665 File Offset: 0x0059D865
		public static void StartIStartRotationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060292F2 RID: 168690 RVA: 0x0059F66E File Offset: 0x0059D86E
		public static void AddTargetRotation(FlatBufferBuilder builder, Offset<IVectorInfo> targetRotationOffset)
		{
			builder.AddOffset(0, targetRotationOffset.Value, 0);
		}

		// Token: 0x060292F3 RID: 168691 RVA: 0x0059F67E File Offset: 0x0059D87E
		public static void AddAngularSpeed(FlatBufferBuilder builder, float angularSpeed)
		{
			builder.AddFloat(1, angularSpeed, 0.0);
		}

		// Token: 0x060292F4 RID: 168692 RVA: 0x0059F691 File Offset: 0x0059D891
		public static Offset<IStartRotationConfig> EndIStartRotationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStartRotationConfig>(builder.EndTable());
		}

		// Token: 0x060292F5 RID: 168693 RVA: 0x0059F6A0 File Offset: 0x0059D8A0
		public IStartRotationConfigT UnPack()
		{
			IStartRotationConfigT startRotationConfigT = new IStartRotationConfigT();
			this.UnPackTo(startRotationConfigT);
			return startRotationConfigT;
		}

		// Token: 0x060292F6 RID: 168694 RVA: 0x0059F6BC File Offset: 0x0059D8BC
		public void UnPackTo(IStartRotationConfigT _o)
		{
			_o.TargetRotation = ((this.TargetRotation != null) ? this.TargetRotation.Value.UnPack() : null);
			_o.AngularSpeed = this.AngularSpeed;
		}

		// Token: 0x060292F7 RID: 168695 RVA: 0x0059F704 File Offset: 0x0059D904
		public static Offset<IStartRotationConfig> Pack(FlatBufferBuilder builder, IStartRotationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStartRotationConfig>);
			}
			Offset<IVectorInfo> targetRotationOffset = (_o.TargetRotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TargetRotation);
			return IStartRotationConfig.CreateIStartRotationConfig(builder, targetRotationOffset, _o.AngularSpeed);
		}

		// Token: 0x0400FC97 RID: 64663
		private Table __p;
	}
}
