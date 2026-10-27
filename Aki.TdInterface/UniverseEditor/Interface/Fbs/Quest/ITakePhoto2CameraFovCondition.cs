using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004178 RID: 16760
	public struct ITakePhoto2CameraFovCondition : IFlatbufferObject
	{
		// Token: 0x170076AD RID: 30381
		// (get) Token: 0x060189E5 RID: 100837 RVA: 0x0038BB02 File Offset: 0x00389D02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060189E6 RID: 100838 RVA: 0x0038BB0F File Offset: 0x00389D0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060189E7 RID: 100839 RVA: 0x0038BB18 File Offset: 0x00389D18
		public static ITakePhoto2CameraFovCondition GetRootAsITakePhoto2CameraFovCondition(ByteBuffer _bb)
		{
			return ITakePhoto2CameraFovCondition.GetRootAsITakePhoto2CameraFovCondition(_bb, default(ITakePhoto2CameraFovCondition));
		}

		// Token: 0x060189E8 RID: 100840 RVA: 0x0038BB34 File Offset: 0x00389D34
		public static ITakePhoto2CameraFovCondition GetRootAsITakePhoto2CameraFovCondition(ByteBuffer _bb, ITakePhoto2CameraFovCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060189E9 RID: 100841 RVA: 0x0038BB51 File Offset: 0x00389D51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060189EA RID: 100842 RVA: 0x0038BB60 File Offset: 0x00389D60
		public ITakePhoto2CameraFovCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076AE RID: 30382
		// (get) Token: 0x060189EB RID: 100843 RVA: 0x0038BB70 File Offset: 0x00389D70
		public int MinFov
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170076AF RID: 30383
		// (get) Token: 0x060189EC RID: 100844 RVA: 0x0038BBAC File Offset: 0x00389DAC
		public int MaxFov
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

		// Token: 0x060189ED RID: 100845 RVA: 0x0038BBE8 File Offset: 0x00389DE8
		public static Offset<ITakePhoto2CameraFovCondition> CreateITakePhoto2CameraFovCondition(FlatBufferBuilder builder, int MinFov = 0, int MaxFov = 0)
		{
			builder.StartTable(2);
			ITakePhoto2CameraFovCondition.AddMaxFov(builder, MaxFov);
			ITakePhoto2CameraFovCondition.AddMinFov(builder, MinFov);
			return ITakePhoto2CameraFovCondition.EndITakePhoto2CameraFovCondition(builder);
		}

		// Token: 0x060189EE RID: 100846 RVA: 0x0038BC05 File Offset: 0x00389E05
		public static void StartITakePhoto2CameraFovCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060189EF RID: 100847 RVA: 0x0038BC0E File Offset: 0x00389E0E
		public static void AddMinFov(FlatBufferBuilder builder, int minFov)
		{
			builder.AddInt(0, minFov, 0);
		}

		// Token: 0x060189F0 RID: 100848 RVA: 0x0038BC19 File Offset: 0x00389E19
		public static void AddMaxFov(FlatBufferBuilder builder, int maxFov)
		{
			builder.AddInt(1, maxFov, 0);
		}

		// Token: 0x060189F1 RID: 100849 RVA: 0x0038BC24 File Offset: 0x00389E24
		public static Offset<ITakePhoto2CameraFovCondition> EndITakePhoto2CameraFovCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2CameraFovCondition>(builder.EndTable());
		}

		// Token: 0x060189F2 RID: 100850 RVA: 0x0038BC34 File Offset: 0x00389E34
		public ITakePhoto2CameraFovConditionT UnPack()
		{
			ITakePhoto2CameraFovConditionT takePhoto2CameraFovConditionT = new ITakePhoto2CameraFovConditionT();
			this.UnPackTo(takePhoto2CameraFovConditionT);
			return takePhoto2CameraFovConditionT;
		}

		// Token: 0x060189F3 RID: 100851 RVA: 0x0038BC4F File Offset: 0x00389E4F
		public void UnPackTo(ITakePhoto2CameraFovConditionT _o)
		{
			_o.MinFov = this.MinFov;
			_o.MaxFov = this.MaxFov;
		}

		// Token: 0x060189F4 RID: 100852 RVA: 0x0038BC6C File Offset: 0x00389E6C
		public static Offset<ITakePhoto2CameraFovCondition> Pack(FlatBufferBuilder builder, ITakePhoto2CameraFovConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2CameraFovCondition>);
			}
			return ITakePhoto2CameraFovCondition.CreateITakePhoto2CameraFovCondition(builder, _o.MinFov, _o.MaxFov);
		}

		// Token: 0x0400BD95 RID: 48533
		private Table __p;
	}
}
