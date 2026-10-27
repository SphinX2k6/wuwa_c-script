using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005998 RID: 22936
	public struct IStartRotationConfig : IFlatbufferObject
	{
		// Token: 0x1700AC1E RID: 44062
		// (get) Token: 0x06026D7E RID: 159102 RVA: 0x005588CE File Offset: 0x00556ACE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026D7F RID: 159103 RVA: 0x005588DB File Offset: 0x00556ADB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026D80 RID: 159104 RVA: 0x005588E4 File Offset: 0x00556AE4
		public static IStartRotationConfig GetRootAsIStartRotationConfig(ByteBuffer _bb)
		{
			return IStartRotationConfig.GetRootAsIStartRotationConfig(_bb, default(IStartRotationConfig));
		}

		// Token: 0x06026D81 RID: 159105 RVA: 0x00558900 File Offset: 0x00556B00
		public static IStartRotationConfig GetRootAsIStartRotationConfig(ByteBuffer _bb, IStartRotationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026D82 RID: 159106 RVA: 0x0055891D File Offset: 0x00556B1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026D83 RID: 159107 RVA: 0x0055892C File Offset: 0x00556B2C
		public IStartRotationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC1F RID: 44063
		// (get) Token: 0x06026D84 RID: 159108 RVA: 0x0055893C File Offset: 0x00556B3C
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

		// Token: 0x1700AC20 RID: 44064
		// (get) Token: 0x06026D85 RID: 159109 RVA: 0x0055899C File Offset: 0x00556B9C
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

		// Token: 0x06026D86 RID: 159110 RVA: 0x005589DC File Offset: 0x00556BDC
		public static Offset<IStartRotationConfig> CreateIStartRotationConfig(FlatBufferBuilder builder, Offset<IVectorInfo> TargetRotationOffset = default(Offset<IVectorInfo>), float AngularSpeed = 0f)
		{
			builder.StartTable(2);
			IStartRotationConfig.AddAngularSpeed(builder, AngularSpeed);
			IStartRotationConfig.AddTargetRotation(builder, TargetRotationOffset);
			return IStartRotationConfig.EndIStartRotationConfig(builder);
		}

		// Token: 0x06026D87 RID: 159111 RVA: 0x005589F9 File Offset: 0x00556BF9
		public static void StartIStartRotationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026D88 RID: 159112 RVA: 0x00558A02 File Offset: 0x00556C02
		public static void AddTargetRotation(FlatBufferBuilder builder, Offset<IVectorInfo> targetRotationOffset)
		{
			builder.AddOffset(0, targetRotationOffset.Value, 0);
		}

		// Token: 0x06026D89 RID: 159113 RVA: 0x00558A12 File Offset: 0x00556C12
		public static void AddAngularSpeed(FlatBufferBuilder builder, float angularSpeed)
		{
			builder.AddFloat(1, angularSpeed, 0.0);
		}

		// Token: 0x06026D8A RID: 159114 RVA: 0x00558A25 File Offset: 0x00556C25
		public static Offset<IStartRotationConfig> EndIStartRotationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStartRotationConfig>(builder.EndTable());
		}

		// Token: 0x06026D8B RID: 159115 RVA: 0x00558A34 File Offset: 0x00556C34
		public IStartRotationConfigT UnPack()
		{
			IStartRotationConfigT startRotationConfigT = new IStartRotationConfigT();
			this.UnPackTo(startRotationConfigT);
			return startRotationConfigT;
		}

		// Token: 0x06026D8C RID: 159116 RVA: 0x00558A50 File Offset: 0x00556C50
		public void UnPackTo(IStartRotationConfigT _o)
		{
			_o.TargetRotation = ((this.TargetRotation != null) ? this.TargetRotation.Value.UnPack() : null);
			_o.AngularSpeed = this.AngularSpeed;
		}

		// Token: 0x06026D8D RID: 159117 RVA: 0x00558A98 File Offset: 0x00556C98
		public static Offset<IStartRotationConfig> Pack(FlatBufferBuilder builder, IStartRotationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStartRotationConfig>);
			}
			Offset<IVectorInfo> targetRotationOffset = (_o.TargetRotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TargetRotation);
			return IStartRotationConfig.CreateIStartRotationConfig(builder, targetRotationOffset, _o.AngularSpeed);
		}

		// Token: 0x0400EFA2 RID: 61346
		private Table __p;
	}
}
