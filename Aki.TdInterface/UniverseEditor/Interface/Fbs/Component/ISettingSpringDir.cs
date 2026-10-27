using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005905 RID: 22789
	public struct ISettingSpringDir : IFlatbufferObject
	{
		// Token: 0x1700AACF RID: 43727
		// (get) Token: 0x0602682C RID: 157740 RVA: 0x0054E4B8 File Offset: 0x0054C6B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602682D RID: 157741 RVA: 0x0054E4C5 File Offset: 0x0054C6C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602682E RID: 157742 RVA: 0x0054E4CC File Offset: 0x0054C6CC
		public static ISettingSpringDir GetRootAsISettingSpringDir(ByteBuffer _bb)
		{
			return ISettingSpringDir.GetRootAsISettingSpringDir(_bb, default(ISettingSpringDir));
		}

		// Token: 0x0602682F RID: 157743 RVA: 0x0054E4E8 File Offset: 0x0054C6E8
		public static ISettingSpringDir GetRootAsISettingSpringDir(ByteBuffer _bb, ISettingSpringDir obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026830 RID: 157744 RVA: 0x0054E505 File Offset: 0x0054C705
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026831 RID: 157745 RVA: 0x0054E514 File Offset: 0x0054C714
		public ISettingSpringDir __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAD0 RID: 43728
		// (get) Token: 0x06026832 RID: 157746 RVA: 0x0054E524 File Offset: 0x0054C724
		public bool IsSettingDir
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AAD1 RID: 43729
		// (get) Token: 0x06026833 RID: 157747 RVA: 0x0054E564 File Offset: 0x0054C764
		public bool IsRotator
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AAD2 RID: 43730
		// (get) Token: 0x06026834 RID: 157748 RVA: 0x0054E5A4 File Offset: 0x0054C7A4
		public IVectorInfo? SpringDir
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06026835 RID: 157749 RVA: 0x0054E601 File Offset: 0x0054C801
		public static Offset<ISettingSpringDir> CreateISettingSpringDir(FlatBufferBuilder builder, bool IsSettingDir = false, bool IsRotator = false, Offset<IVectorInfo> SpringDirOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			ISettingSpringDir.AddSpringDir(builder, SpringDirOffset);
			ISettingSpringDir.AddIsRotator(builder, IsRotator);
			ISettingSpringDir.AddIsSettingDir(builder, IsSettingDir);
			return ISettingSpringDir.EndISettingSpringDir(builder);
		}

		// Token: 0x06026836 RID: 157750 RVA: 0x0054E625 File Offset: 0x0054C825
		public static void StartISettingSpringDir(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026837 RID: 157751 RVA: 0x0054E62E File Offset: 0x0054C82E
		public static void AddIsSettingDir(FlatBufferBuilder builder, bool isSettingDir)
		{
			builder.AddBool(0, isSettingDir, false);
		}

		// Token: 0x06026838 RID: 157752 RVA: 0x0054E639 File Offset: 0x0054C839
		public static void AddIsRotator(FlatBufferBuilder builder, bool isRotator)
		{
			builder.AddBool(1, isRotator, false);
		}

		// Token: 0x06026839 RID: 157753 RVA: 0x0054E644 File Offset: 0x0054C844
		public static void AddSpringDir(FlatBufferBuilder builder, Offset<IVectorInfo> springDirOffset)
		{
			builder.AddOffset(2, springDirOffset.Value, 0);
		}

		// Token: 0x0602683A RID: 157754 RVA: 0x0054E654 File Offset: 0x0054C854
		public static Offset<ISettingSpringDir> EndISettingSpringDir(FlatBufferBuilder builder)
		{
			return new Offset<ISettingSpringDir>(builder.EndTable());
		}

		// Token: 0x0602683B RID: 157755 RVA: 0x0054E664 File Offset: 0x0054C864
		public ISettingSpringDirT UnPack()
		{
			ISettingSpringDirT settingSpringDirT = new ISettingSpringDirT();
			this.UnPackTo(settingSpringDirT);
			return settingSpringDirT;
		}

		// Token: 0x0602683C RID: 157756 RVA: 0x0054E680 File Offset: 0x0054C880
		public void UnPackTo(ISettingSpringDirT _o)
		{
			_o.IsSettingDir = this.IsSettingDir;
			_o.IsRotator = this.IsRotator;
			_o.SpringDir = ((this.SpringDir != null) ? this.SpringDir.Value.UnPack() : null);
		}

		// Token: 0x0602683D RID: 157757 RVA: 0x0054E6D4 File Offset: 0x0054C8D4
		public static Offset<ISettingSpringDir> Pack(FlatBufferBuilder builder, ISettingSpringDirT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISettingSpringDir>);
			}
			Offset<IVectorInfo> springDirOffset = (_o.SpringDir == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.SpringDir);
			return ISettingSpringDir.CreateISettingSpringDir(builder, _o.IsSettingDir, _o.IsRotator, springDirOffset);
		}

		// Token: 0x0400EEA5 RID: 61093
		private Table __p;
	}
}
