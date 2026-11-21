using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006829 RID: 26665
	public struct IAutomaticDrive : IFlatbufferObject
	{
		// Token: 0x1700C409 RID: 50185
		// (get) Token: 0x0602D905 RID: 186629 RVA: 0x0063C3C2 File Offset: 0x0063A5C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D906 RID: 186630 RVA: 0x0063C3CF File Offset: 0x0063A5CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D907 RID: 186631 RVA: 0x0063C3D8 File Offset: 0x0063A5D8
		public static IAutomaticDrive GetRootAsIAutomaticDrive(ByteBuffer _bb)
		{
			return IAutomaticDrive.GetRootAsIAutomaticDrive(_bb, default(IAutomaticDrive));
		}

		// Token: 0x0602D908 RID: 186632 RVA: 0x0063C3F4 File Offset: 0x0063A5F4
		public static IAutomaticDrive GetRootAsIAutomaticDrive(ByteBuffer _bb, IAutomaticDrive obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D909 RID: 186633 RVA: 0x0063C411 File Offset: 0x0063A611
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D90A RID: 186634 RVA: 0x0063C420 File Offset: 0x0063A620
		public IAutomaticDrive __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C40A RID: 50186
		// (get) Token: 0x0602D90B RID: 186635 RVA: 0x0063C430 File Offset: 0x0063A630
		public float StandbyTime
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D90C RID: 186636 RVA: 0x0063C470 File Offset: 0x0063A670
		public static Offset<IAutomaticDrive> CreateIAutomaticDrive(FlatBufferBuilder builder, float StandbyTime = 0f)
		{
			builder.StartTable(1);
			IAutomaticDrive.AddStandbyTime(builder, StandbyTime);
			return IAutomaticDrive.EndIAutomaticDrive(builder);
		}

		// Token: 0x0602D90D RID: 186637 RVA: 0x0063C486 File Offset: 0x0063A686
		public static void StartIAutomaticDrive(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D90E RID: 186638 RVA: 0x0063C48F File Offset: 0x0063A68F
		public static void AddStandbyTime(FlatBufferBuilder builder, float standbyTime)
		{
			builder.AddFloat(0, standbyTime, 0.0);
		}

		// Token: 0x0602D90F RID: 186639 RVA: 0x0063C4A2 File Offset: 0x0063A6A2
		public static Offset<IAutomaticDrive> EndIAutomaticDrive(FlatBufferBuilder builder)
		{
			return new Offset<IAutomaticDrive>(builder.EndTable());
		}

		// Token: 0x0602D910 RID: 186640 RVA: 0x0063C4B0 File Offset: 0x0063A6B0
		public IAutomaticDriveT UnPack()
		{
			IAutomaticDriveT automaticDriveT = new IAutomaticDriveT();
			this.UnPackTo(automaticDriveT);
			return automaticDriveT;
		}

		// Token: 0x0602D911 RID: 186641 RVA: 0x0063C4CB File Offset: 0x0063A6CB
		public void UnPackTo(IAutomaticDriveT _o)
		{
			_o.StandbyTime = this.StandbyTime;
		}

		// Token: 0x0602D912 RID: 186642 RVA: 0x0063C4DC File Offset: 0x0063A6DC
		public static Offset<IAutomaticDrive> Pack(FlatBufferBuilder builder, IAutomaticDriveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAutomaticDrive>);
			}
			return IAutomaticDrive.CreateIAutomaticDrive(builder, _o.StandbyTime);
		}

		// Token: 0x040114EE RID: 70894
		private Table __p;
	}
}
