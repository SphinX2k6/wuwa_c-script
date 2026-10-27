using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D83 RID: 28035
	public struct IPostProcessVolumeCenterPosition : IFlatbufferObject
	{
		// Token: 0x1700D12A RID: 53546
		// (get) Token: 0x0603185A RID: 202842 RVA: 0x006B67E8 File Offset: 0x006B49E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603185B RID: 202843 RVA: 0x006B67F5 File Offset: 0x006B49F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603185C RID: 202844 RVA: 0x006B67FC File Offset: 0x006B49FC
		public static IPostProcessVolumeCenterPosition GetRootAsIPostProcessVolumeCenterPosition(ByteBuffer _bb)
		{
			return IPostProcessVolumeCenterPosition.GetRootAsIPostProcessVolumeCenterPosition(_bb, default(IPostProcessVolumeCenterPosition));
		}

		// Token: 0x0603185D RID: 202845 RVA: 0x006B6818 File Offset: 0x006B4A18
		public static IPostProcessVolumeCenterPosition GetRootAsIPostProcessVolumeCenterPosition(ByteBuffer _bb, IPostProcessVolumeCenterPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603185E RID: 202846 RVA: 0x006B6835 File Offset: 0x006B4A35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603185F RID: 202847 RVA: 0x006B6844 File Offset: 0x006B4A44
		public IPostProcessVolumeCenterPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D12B RID: 53547
		// (get) Token: 0x06031860 RID: 202848 RVA: 0x006B6854 File Offset: 0x006B4A54
		public EMpcEffectParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMpcEffectParamType.PostProcessVolumeCenterPosition;
				}
				return (EMpcEffectParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D12C RID: 53548
		// (get) Token: 0x06031861 RID: 202849 RVA: 0x006B6890 File Offset: 0x006B4A90
		public IVectorInfo? Position
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

		// Token: 0x06031862 RID: 202850 RVA: 0x006B68ED File Offset: 0x006B4AED
		public static Offset<IPostProcessVolumeCenterPosition> CreateIPostProcessVolumeCenterPosition(FlatBufferBuilder builder, EMpcEffectParamType Type = EMpcEffectParamType.PostProcessVolumeCenterPosition, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPostProcessVolumeCenterPosition.AddPosition(builder, PositionOffset);
			IPostProcessVolumeCenterPosition.AddType(builder, Type);
			return IPostProcessVolumeCenterPosition.EndIPostProcessVolumeCenterPosition(builder);
		}

		// Token: 0x06031863 RID: 202851 RVA: 0x006B690A File Offset: 0x006B4B0A
		public static void StartIPostProcessVolumeCenterPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031864 RID: 202852 RVA: 0x006B6913 File Offset: 0x006B4B13
		public static void AddType(FlatBufferBuilder builder, EMpcEffectParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031865 RID: 202853 RVA: 0x006B691E File Offset: 0x006B4B1E
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x06031866 RID: 202854 RVA: 0x006B692E File Offset: 0x006B4B2E
		public static Offset<IPostProcessVolumeCenterPosition> EndIPostProcessVolumeCenterPosition(FlatBufferBuilder builder)
		{
			return new Offset<IPostProcessVolumeCenterPosition>(builder.EndTable());
		}

		// Token: 0x06031867 RID: 202855 RVA: 0x006B693C File Offset: 0x006B4B3C
		public IPostProcessVolumeCenterPositionT UnPack()
		{
			IPostProcessVolumeCenterPositionT postProcessVolumeCenterPositionT = new IPostProcessVolumeCenterPositionT();
			this.UnPackTo(postProcessVolumeCenterPositionT);
			return postProcessVolumeCenterPositionT;
		}

		// Token: 0x06031868 RID: 202856 RVA: 0x006B6958 File Offset: 0x006B4B58
		public void UnPackTo(IPostProcessVolumeCenterPositionT _o)
		{
			_o.Type = this.Type;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x06031869 RID: 202857 RVA: 0x006B69A0 File Offset: 0x006B4BA0
		public static Offset<IPostProcessVolumeCenterPosition> Pack(FlatBufferBuilder builder, IPostProcessVolumeCenterPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPostProcessVolumeCenterPosition>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			return IPostProcessVolumeCenterPosition.CreateIPostProcessVolumeCenterPosition(builder, _o.Type, positionOffset);
		}

		// Token: 0x04011751 RID: 71505
		private Table __p;
	}
}
