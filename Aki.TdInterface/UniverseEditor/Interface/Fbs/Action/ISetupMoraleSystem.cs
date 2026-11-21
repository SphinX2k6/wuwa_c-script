using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200786C RID: 30828
	public struct ISetupMoraleSystem : IFlatbufferObject
	{
		// Token: 0x1700E217 RID: 57879
		// (get) Token: 0x06036377 RID: 222071 RVA: 0x00743248 File Offset: 0x00741448
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036378 RID: 222072 RVA: 0x00743255 File Offset: 0x00741455
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036379 RID: 222073 RVA: 0x0074325C File Offset: 0x0074145C
		public static ISetupMoraleSystem GetRootAsISetupMoraleSystem(ByteBuffer _bb)
		{
			return ISetupMoraleSystem.GetRootAsISetupMoraleSystem(_bb, default(ISetupMoraleSystem));
		}

		// Token: 0x0603637A RID: 222074 RVA: 0x00743278 File Offset: 0x00741478
		public static ISetupMoraleSystem GetRootAsISetupMoraleSystem(ByteBuffer _bb, ISetupMoraleSystem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603637B RID: 222075 RVA: 0x00743295 File Offset: 0x00741495
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603637C RID: 222076 RVA: 0x007432A4 File Offset: 0x007414A4
		public ISetupMoraleSystem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E218 RID: 57880
		// (get) Token: 0x0603637D RID: 222077 RVA: 0x007432B4 File Offset: 0x007414B4
		public int MoralePlayId
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

		// Token: 0x1700E219 RID: 57881
		// (get) Token: 0x0603637E RID: 222078 RVA: 0x007432F0 File Offset: 0x007414F0
		public bool IsOn
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0603637F RID: 222079 RVA: 0x0074332F File Offset: 0x0074152F
		public static Offset<ISetupMoraleSystem> CreateISetupMoraleSystem(FlatBufferBuilder builder, int MoralePlayId = 0, bool IsOn = false)
		{
			builder.StartTable(2);
			ISetupMoraleSystem.AddMoralePlayId(builder, MoralePlayId);
			ISetupMoraleSystem.AddIsOn(builder, IsOn);
			return ISetupMoraleSystem.EndISetupMoraleSystem(builder);
		}

		// Token: 0x06036380 RID: 222080 RVA: 0x0074334C File Offset: 0x0074154C
		public static void StartISetupMoraleSystem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036381 RID: 222081 RVA: 0x00743355 File Offset: 0x00741555
		public static void AddMoralePlayId(FlatBufferBuilder builder, int moralePlayId)
		{
			builder.AddInt(0, moralePlayId, 0);
		}

		// Token: 0x06036382 RID: 222082 RVA: 0x00743360 File Offset: 0x00741560
		public static void AddIsOn(FlatBufferBuilder builder, bool isOn)
		{
			builder.AddBool(1, isOn, false);
		}

		// Token: 0x06036383 RID: 222083 RVA: 0x0074336B File Offset: 0x0074156B
		public static Offset<ISetupMoraleSystem> EndISetupMoraleSystem(FlatBufferBuilder builder)
		{
			return new Offset<ISetupMoraleSystem>(builder.EndTable());
		}

		// Token: 0x06036384 RID: 222084 RVA: 0x00743378 File Offset: 0x00741578
		public ISetupMoraleSystemT UnPack()
		{
			ISetupMoraleSystemT setupMoraleSystemT = new ISetupMoraleSystemT();
			this.UnPackTo(setupMoraleSystemT);
			return setupMoraleSystemT;
		}

		// Token: 0x06036385 RID: 222085 RVA: 0x00743393 File Offset: 0x00741593
		public void UnPackTo(ISetupMoraleSystemT _o)
		{
			_o.MoralePlayId = this.MoralePlayId;
			_o.IsOn = this.IsOn;
		}

		// Token: 0x06036386 RID: 222086 RVA: 0x007433B0 File Offset: 0x007415B0
		public static Offset<ISetupMoraleSystem> Pack(FlatBufferBuilder builder, ISetupMoraleSystemT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetupMoraleSystem>);
			}
			return ISetupMoraleSystem.CreateISetupMoraleSystem(builder, _o.MoralePlayId, _o.IsOn);
		}

		// Token: 0x04012AF6 RID: 76534
		private Table __p;
	}
}
