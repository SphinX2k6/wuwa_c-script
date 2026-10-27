using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F13 RID: 20243
	public struct IBeamReflectionConfig : IFlatbufferObject
	{
		// Token: 0x170091C4 RID: 37316
		// (get) Token: 0x06020016 RID: 131094 RVA: 0x004744D7 File Offset: 0x004726D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020017 RID: 131095 RVA: 0x004744E4 File Offset: 0x004726E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020018 RID: 131096 RVA: 0x004744EC File Offset: 0x004726EC
		public static IBeamReflectionConfig GetRootAsIBeamReflectionConfig(ByteBuffer _bb)
		{
			return IBeamReflectionConfig.GetRootAsIBeamReflectionConfig(_bb, default(IBeamReflectionConfig));
		}

		// Token: 0x06020019 RID: 131097 RVA: 0x00474508 File Offset: 0x00472708
		public static IBeamReflectionConfig GetRootAsIBeamReflectionConfig(ByteBuffer _bb, IBeamReflectionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602001A RID: 131098 RVA: 0x00474525 File Offset: 0x00472725
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602001B RID: 131099 RVA: 0x00474534 File Offset: 0x00472734
		public IBeamReflectionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091C5 RID: 37317
		// (get) Token: 0x0602001C RID: 131100 RVA: 0x00474544 File Offset: 0x00472744
		public IVectorInfo? NormalVector
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

		// Token: 0x0602001D RID: 131101 RVA: 0x004745A1 File Offset: 0x004727A1
		public static Offset<IBeamReflectionConfig> CreateIBeamReflectionConfig(FlatBufferBuilder builder, Offset<IVectorInfo> NormalVectorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(1);
			IBeamReflectionConfig.AddNormalVector(builder, NormalVectorOffset);
			return IBeamReflectionConfig.EndIBeamReflectionConfig(builder);
		}

		// Token: 0x0602001E RID: 131102 RVA: 0x004745B7 File Offset: 0x004727B7
		public static void StartIBeamReflectionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602001F RID: 131103 RVA: 0x004745C0 File Offset: 0x004727C0
		public static void AddNormalVector(FlatBufferBuilder builder, Offset<IVectorInfo> normalVectorOffset)
		{
			builder.AddOffset(0, normalVectorOffset.Value, 0);
		}

		// Token: 0x06020020 RID: 131104 RVA: 0x004745D0 File Offset: 0x004727D0
		public static Offset<IBeamReflectionConfig> EndIBeamReflectionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBeamReflectionConfig>(builder.EndTable());
		}

		// Token: 0x06020021 RID: 131105 RVA: 0x004745E0 File Offset: 0x004727E0
		public IBeamReflectionConfigT UnPack()
		{
			IBeamReflectionConfigT beamReflectionConfigT = new IBeamReflectionConfigT();
			this.UnPackTo(beamReflectionConfigT);
			return beamReflectionConfigT;
		}

		// Token: 0x06020022 RID: 131106 RVA: 0x004745FC File Offset: 0x004727FC
		public void UnPackTo(IBeamReflectionConfigT _o)
		{
			_o.NormalVector = ((this.NormalVector != null) ? this.NormalVector.Value.UnPack() : null);
		}

		// Token: 0x06020023 RID: 131107 RVA: 0x00474638 File Offset: 0x00472838
		public static Offset<IBeamReflectionConfig> Pack(FlatBufferBuilder builder, IBeamReflectionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBeamReflectionConfig>);
			}
			Offset<IVectorInfo> normalVectorOffset = (_o.NormalVector == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.NormalVector);
			return IBeamReflectionConfig.CreateIBeamReflectionConfig(builder, normalVectorOffset);
		}

		// Token: 0x0400DD60 RID: 56672
		private Table __p;
	}
}
