using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F12 RID: 24338
	public struct ISettingSpringDir : IFlatbufferObject
	{
		// Token: 0x1700B403 RID: 46083
		// (get) Token: 0x06028D96 RID: 167318 RVA: 0x00595124 File Offset: 0x00593324
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028D97 RID: 167319 RVA: 0x00595131 File Offset: 0x00593331
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028D98 RID: 167320 RVA: 0x00595138 File Offset: 0x00593338
		public static ISettingSpringDir GetRootAsISettingSpringDir(ByteBuffer _bb)
		{
			return ISettingSpringDir.GetRootAsISettingSpringDir(_bb, default(ISettingSpringDir));
		}

		// Token: 0x06028D99 RID: 167321 RVA: 0x00595154 File Offset: 0x00593354
		public static ISettingSpringDir GetRootAsISettingSpringDir(ByteBuffer _bb, ISettingSpringDir obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028D9A RID: 167322 RVA: 0x00595171 File Offset: 0x00593371
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028D9B RID: 167323 RVA: 0x00595180 File Offset: 0x00593380
		public ISettingSpringDir __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B404 RID: 46084
		// (get) Token: 0x06028D9C RID: 167324 RVA: 0x00595190 File Offset: 0x00593390
		public bool IsSettingDir
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B405 RID: 46085
		// (get) Token: 0x06028D9D RID: 167325 RVA: 0x005951D0 File Offset: 0x005933D0
		public bool IsRotator
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B406 RID: 46086
		// (get) Token: 0x06028D9E RID: 167326 RVA: 0x00595210 File Offset: 0x00593410
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

		// Token: 0x06028D9F RID: 167327 RVA: 0x0059526D File Offset: 0x0059346D
		public static Offset<ISettingSpringDir> CreateISettingSpringDir(FlatBufferBuilder builder, bool IsSettingDir = false, bool IsRotator = false, Offset<IVectorInfo> SpringDirOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			ISettingSpringDir.AddSpringDir(builder, SpringDirOffset);
			ISettingSpringDir.AddIsRotator(builder, IsRotator);
			ISettingSpringDir.AddIsSettingDir(builder, IsSettingDir);
			return ISettingSpringDir.EndISettingSpringDir(builder);
		}

		// Token: 0x06028DA0 RID: 167328 RVA: 0x00595291 File Offset: 0x00593491
		public static void StartISettingSpringDir(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028DA1 RID: 167329 RVA: 0x0059529A File Offset: 0x0059349A
		public static void AddIsSettingDir(FlatBufferBuilder builder, bool isSettingDir)
		{
			builder.AddBool(0, isSettingDir, false);
		}

		// Token: 0x06028DA2 RID: 167330 RVA: 0x005952A5 File Offset: 0x005934A5
		public static void AddIsRotator(FlatBufferBuilder builder, bool isRotator)
		{
			builder.AddBool(1, isRotator, false);
		}

		// Token: 0x06028DA3 RID: 167331 RVA: 0x005952B0 File Offset: 0x005934B0
		public static void AddSpringDir(FlatBufferBuilder builder, Offset<IVectorInfo> springDirOffset)
		{
			builder.AddOffset(2, springDirOffset.Value, 0);
		}

		// Token: 0x06028DA4 RID: 167332 RVA: 0x005952C0 File Offset: 0x005934C0
		public static Offset<ISettingSpringDir> EndISettingSpringDir(FlatBufferBuilder builder)
		{
			return new Offset<ISettingSpringDir>(builder.EndTable());
		}

		// Token: 0x06028DA5 RID: 167333 RVA: 0x005952D0 File Offset: 0x005934D0
		public ISettingSpringDirT UnPack()
		{
			ISettingSpringDirT settingSpringDirT = new ISettingSpringDirT();
			this.UnPackTo(settingSpringDirT);
			return settingSpringDirT;
		}

		// Token: 0x06028DA6 RID: 167334 RVA: 0x005952EC File Offset: 0x005934EC
		public void UnPackTo(ISettingSpringDirT _o)
		{
			_o.IsSettingDir = this.IsSettingDir;
			_o.IsRotator = this.IsRotator;
			_o.SpringDir = ((this.SpringDir != null) ? this.SpringDir.Value.UnPack() : null);
		}

		// Token: 0x06028DA7 RID: 167335 RVA: 0x00595340 File Offset: 0x00593540
		public static Offset<ISettingSpringDir> Pack(FlatBufferBuilder builder, ISettingSpringDirT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISettingSpringDir>);
			}
			Offset<IVectorInfo> springDirOffset = (_o.SpringDir == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.SpringDir);
			return ISettingSpringDir.CreateISettingSpringDir(builder, _o.IsSettingDir, _o.IsRotator, springDirOffset);
		}

		// Token: 0x0400FB9A RID: 64410
		private Table __p;
	}
}
