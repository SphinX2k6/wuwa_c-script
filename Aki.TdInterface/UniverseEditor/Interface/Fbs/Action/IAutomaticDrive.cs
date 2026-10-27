using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061BB RID: 25019
	public struct IAutomaticDrive : IFlatbufferObject
	{
		// Token: 0x1700BA86 RID: 47750
		// (get) Token: 0x0602B1BE RID: 176574 RVA: 0x005F194E File Offset: 0x005EFB4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B1BF RID: 176575 RVA: 0x005F195B File Offset: 0x005EFB5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B1C0 RID: 176576 RVA: 0x005F1964 File Offset: 0x005EFB64
		public static IAutomaticDrive GetRootAsIAutomaticDrive(ByteBuffer _bb)
		{
			return IAutomaticDrive.GetRootAsIAutomaticDrive(_bb, default(IAutomaticDrive));
		}

		// Token: 0x0602B1C1 RID: 176577 RVA: 0x005F1980 File Offset: 0x005EFB80
		public static IAutomaticDrive GetRootAsIAutomaticDrive(ByteBuffer _bb, IAutomaticDrive obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B1C2 RID: 176578 RVA: 0x005F199D File Offset: 0x005EFB9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B1C3 RID: 176579 RVA: 0x005F19AC File Offset: 0x005EFBAC
		public IAutomaticDrive __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA87 RID: 47751
		// (get) Token: 0x0602B1C4 RID: 176580 RVA: 0x005F19BC File Offset: 0x005EFBBC
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

		// Token: 0x0602B1C5 RID: 176581 RVA: 0x005F19FC File Offset: 0x005EFBFC
		public static Offset<IAutomaticDrive> CreateIAutomaticDrive(FlatBufferBuilder builder, float StandbyTime = 0f)
		{
			builder.StartTable(1);
			IAutomaticDrive.AddStandbyTime(builder, StandbyTime);
			return IAutomaticDrive.EndIAutomaticDrive(builder);
		}

		// Token: 0x0602B1C6 RID: 176582 RVA: 0x005F1A12 File Offset: 0x005EFC12
		public static void StartIAutomaticDrive(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B1C7 RID: 176583 RVA: 0x005F1A1B File Offset: 0x005EFC1B
		public static void AddStandbyTime(FlatBufferBuilder builder, float standbyTime)
		{
			builder.AddFloat(0, standbyTime, 0.0);
		}

		// Token: 0x0602B1C8 RID: 176584 RVA: 0x005F1A2E File Offset: 0x005EFC2E
		public static Offset<IAutomaticDrive> EndIAutomaticDrive(FlatBufferBuilder builder)
		{
			return new Offset<IAutomaticDrive>(builder.EndTable());
		}

		// Token: 0x0602B1C9 RID: 176585 RVA: 0x005F1A3C File Offset: 0x005EFC3C
		public IAutomaticDriveT UnPack()
		{
			IAutomaticDriveT automaticDriveT = new IAutomaticDriveT();
			this.UnPackTo(automaticDriveT);
			return automaticDriveT;
		}

		// Token: 0x0602B1CA RID: 176586 RVA: 0x005F1A57 File Offset: 0x005EFC57
		public void UnPackTo(IAutomaticDriveT _o)
		{
			_o.StandbyTime = this.StandbyTime;
		}

		// Token: 0x0602B1CB RID: 176587 RVA: 0x005F1A68 File Offset: 0x005EFC68
		public static Offset<IAutomaticDrive> Pack(FlatBufferBuilder builder, IAutomaticDriveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAutomaticDrive>);
			}
			return IAutomaticDrive.CreateIAutomaticDrive(builder, _o.StandbyTime);
		}

		// Token: 0x040106DC RID: 67292
		private Table __p;
	}
}
