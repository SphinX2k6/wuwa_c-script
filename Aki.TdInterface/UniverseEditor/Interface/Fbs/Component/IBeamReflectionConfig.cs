using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005445 RID: 21573
	public struct IBeamReflectionConfig : IFlatbufferObject
	{
		// Token: 0x17009946 RID: 39238
		// (get) Token: 0x06021D86 RID: 138630 RVA: 0x004AA86B File Offset: 0x004A8A6B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021D87 RID: 138631 RVA: 0x004AA878 File Offset: 0x004A8A78
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021D88 RID: 138632 RVA: 0x004AA880 File Offset: 0x004A8A80
		public static IBeamReflectionConfig GetRootAsIBeamReflectionConfig(ByteBuffer _bb)
		{
			return IBeamReflectionConfig.GetRootAsIBeamReflectionConfig(_bb, default(IBeamReflectionConfig));
		}

		// Token: 0x06021D89 RID: 138633 RVA: 0x004AA89C File Offset: 0x004A8A9C
		public static IBeamReflectionConfig GetRootAsIBeamReflectionConfig(ByteBuffer _bb, IBeamReflectionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021D8A RID: 138634 RVA: 0x004AA8B9 File Offset: 0x004A8AB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021D8B RID: 138635 RVA: 0x004AA8C8 File Offset: 0x004A8AC8
		public IBeamReflectionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009947 RID: 39239
		// (get) Token: 0x06021D8C RID: 138636 RVA: 0x004AA8D8 File Offset: 0x004A8AD8
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

		// Token: 0x06021D8D RID: 138637 RVA: 0x004AA935 File Offset: 0x004A8B35
		public static Offset<IBeamReflectionConfig> CreateIBeamReflectionConfig(FlatBufferBuilder builder, Offset<IVectorInfo> NormalVectorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(1);
			IBeamReflectionConfig.AddNormalVector(builder, NormalVectorOffset);
			return IBeamReflectionConfig.EndIBeamReflectionConfig(builder);
		}

		// Token: 0x06021D8E RID: 138638 RVA: 0x004AA94B File Offset: 0x004A8B4B
		public static void StartIBeamReflectionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021D8F RID: 138639 RVA: 0x004AA954 File Offset: 0x004A8B54
		public static void AddNormalVector(FlatBufferBuilder builder, Offset<IVectorInfo> normalVectorOffset)
		{
			builder.AddOffset(0, normalVectorOffset.Value, 0);
		}

		// Token: 0x06021D90 RID: 138640 RVA: 0x004AA964 File Offset: 0x004A8B64
		public static Offset<IBeamReflectionConfig> EndIBeamReflectionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBeamReflectionConfig>(builder.EndTable());
		}

		// Token: 0x06021D91 RID: 138641 RVA: 0x004AA974 File Offset: 0x004A8B74
		public IBeamReflectionConfigT UnPack()
		{
			IBeamReflectionConfigT beamReflectionConfigT = new IBeamReflectionConfigT();
			this.UnPackTo(beamReflectionConfigT);
			return beamReflectionConfigT;
		}

		// Token: 0x06021D92 RID: 138642 RVA: 0x004AA990 File Offset: 0x004A8B90
		public void UnPackTo(IBeamReflectionConfigT _o)
		{
			_o.NormalVector = ((this.NormalVector != null) ? this.NormalVector.Value.UnPack() : null);
		}

		// Token: 0x06021D93 RID: 138643 RVA: 0x004AA9CC File Offset: 0x004A8BCC
		public static Offset<IBeamReflectionConfig> Pack(FlatBufferBuilder builder, IBeamReflectionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBeamReflectionConfig>);
			}
			Offset<IVectorInfo> normalVectorOffset = (_o.NormalVector == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.NormalVector);
			return IBeamReflectionConfig.CreateIBeamReflectionConfig(builder, normalVectorOffset);
		}

		// Token: 0x0400E90F RID: 59663
		private Table __p;
	}
}
