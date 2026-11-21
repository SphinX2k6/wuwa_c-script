using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EEC RID: 24300
	public struct ISceneTextGuideUiActionMappingIcon : IFlatbufferObject
	{
		// Token: 0x1700B399 RID: 45977
		// (get) Token: 0x06028BFC RID: 166908 RVA: 0x00591E92 File Offset: 0x00590092
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028BFD RID: 166909 RVA: 0x00591E9F File Offset: 0x0059009F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028BFE RID: 166910 RVA: 0x00591EA8 File Offset: 0x005900A8
		public static ISceneTextGuideUiActionMappingIcon GetRootAsISceneTextGuideUiActionMappingIcon(ByteBuffer _bb)
		{
			return ISceneTextGuideUiActionMappingIcon.GetRootAsISceneTextGuideUiActionMappingIcon(_bb, default(ISceneTextGuideUiActionMappingIcon));
		}

		// Token: 0x06028BFF RID: 166911 RVA: 0x00591EC4 File Offset: 0x005900C4
		public static ISceneTextGuideUiActionMappingIcon GetRootAsISceneTextGuideUiActionMappingIcon(ByteBuffer _bb, ISceneTextGuideUiActionMappingIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028C00 RID: 166912 RVA: 0x00591EE1 File Offset: 0x005900E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028C01 RID: 166913 RVA: 0x00591EF0 File Offset: 0x005900F0
		public ISceneTextGuideUiActionMappingIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B39A RID: 45978
		// (get) Token: 0x06028C02 RID: 166914 RVA: 0x00591F00 File Offset: 0x00590100
		public int Id
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

		// Token: 0x1700B39B RID: 45979
		// (get) Token: 0x06028C03 RID: 166915 RVA: 0x00591F3C File Offset: 0x0059013C
		public string ActionName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028C04 RID: 166916 RVA: 0x00591F73 File Offset: 0x00590173
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028C05 RID: 166917 RVA: 0x00591F82 File Offset: 0x00590182
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06028C06 RID: 166918 RVA: 0x00591F90 File Offset: 0x00590190
		public static Offset<ISceneTextGuideUiActionMappingIcon> CreateISceneTextGuideUiActionMappingIcon(FlatBufferBuilder builder, int Id = 0, StringOffset ActionNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISceneTextGuideUiActionMappingIcon.AddActionName(builder, ActionNameOffset);
			ISceneTextGuideUiActionMappingIcon.AddId(builder, Id);
			return ISceneTextGuideUiActionMappingIcon.EndISceneTextGuideUiActionMappingIcon(builder);
		}

		// Token: 0x06028C07 RID: 166919 RVA: 0x00591FAD File Offset: 0x005901AD
		public static void StartISceneTextGuideUiActionMappingIcon(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028C08 RID: 166920 RVA: 0x00591FB6 File Offset: 0x005901B6
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06028C09 RID: 166921 RVA: 0x00591FC1 File Offset: 0x005901C1
		public static void AddActionName(FlatBufferBuilder builder, StringOffset actionNameOffset)
		{
			builder.AddOffset(1, actionNameOffset.Value, 0);
		}

		// Token: 0x06028C0A RID: 166922 RVA: 0x00591FD1 File Offset: 0x005901D1
		public static Offset<ISceneTextGuideUiActionMappingIcon> EndISceneTextGuideUiActionMappingIcon(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextGuideUiActionMappingIcon>(builder.EndTable());
		}

		// Token: 0x06028C0B RID: 166923 RVA: 0x00591FE0 File Offset: 0x005901E0
		public ISceneTextGuideUiActionMappingIconT UnPack()
		{
			ISceneTextGuideUiActionMappingIconT sceneTextGuideUiActionMappingIconT = new ISceneTextGuideUiActionMappingIconT();
			this.UnPackTo(sceneTextGuideUiActionMappingIconT);
			return sceneTextGuideUiActionMappingIconT;
		}

		// Token: 0x06028C0C RID: 166924 RVA: 0x00591FFB File Offset: 0x005901FB
		public void UnPackTo(ISceneTextGuideUiActionMappingIconT _o)
		{
			_o.Id = this.Id;
			_o.ActionName = this.ActionName;
		}

		// Token: 0x06028C0D RID: 166925 RVA: 0x00592018 File Offset: 0x00590218
		public static Offset<ISceneTextGuideUiActionMappingIcon> Pack(FlatBufferBuilder builder, ISceneTextGuideUiActionMappingIconT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneTextGuideUiActionMappingIcon>);
			}
			StringOffset actionNameOffset = (_o.ActionName == null) ? default(StringOffset) : builder.CreateString(_o.ActionName);
			return ISceneTextGuideUiActionMappingIcon.CreateISceneTextGuideUiActionMappingIcon(builder, _o.Id, actionNameOffset);
		}

		// Token: 0x0400FB59 RID: 64345
		private Table __p;
	}
}
