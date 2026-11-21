using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EC9 RID: 20169
	public struct ICheckEntityIsVisibility : IFlatbufferObject
	{
		// Token: 0x17008FFB RID: 36859
		// (get) Token: 0x0601F4B5 RID: 128181 RVA: 0x0045CAD6 File Offset: 0x0045ACD6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F4B6 RID: 128182 RVA: 0x0045CAE3 File Offset: 0x0045ACE3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F4B7 RID: 128183 RVA: 0x0045CAEC File Offset: 0x0045ACEC
		public static ICheckEntityIsVisibility GetRootAsICheckEntityIsVisibility(ByteBuffer _bb)
		{
			return ICheckEntityIsVisibility.GetRootAsICheckEntityIsVisibility(_bb, default(ICheckEntityIsVisibility));
		}

		// Token: 0x0601F4B8 RID: 128184 RVA: 0x0045CB08 File Offset: 0x0045AD08
		public static ICheckEntityIsVisibility GetRootAsICheckEntityIsVisibility(ByteBuffer _bb, ICheckEntityIsVisibility obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F4B9 RID: 128185 RVA: 0x0045CB25 File Offset: 0x0045AD25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F4BA RID: 128186 RVA: 0x0045CB34 File Offset: 0x0045AD34
		public ICheckEntityIsVisibility __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FFC RID: 36860
		// (get) Token: 0x0601F4BB RID: 128187 RVA: 0x0045CB44 File Offset: 0x0045AD44
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008FFD RID: 36861
		// (get) Token: 0x0601F4BC RID: 128188 RVA: 0x0045CB80 File Offset: 0x0045AD80
		public int EntityId
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

		// Token: 0x17008FFE RID: 36862
		// (get) Token: 0x0601F4BD RID: 128189 RVA: 0x0045CBBC File Offset: 0x0045ADBC
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F4BE RID: 128190 RVA: 0x0045CBFB File Offset: 0x0045ADFB
		public static Offset<ICheckEntityIsVisibility> CreateICheckEntityIsVisibility(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, bool IsVisible = false)
		{
			builder.StartTable(3);
			ICheckEntityIsVisibility.AddEntityId(builder, EntityId);
			ICheckEntityIsVisibility.AddIsVisible(builder, IsVisible);
			ICheckEntityIsVisibility.AddType(builder, Type);
			return ICheckEntityIsVisibility.EndICheckEntityIsVisibility(builder);
		}

		// Token: 0x0601F4BF RID: 128191 RVA: 0x0045CC1F File Offset: 0x0045AE1F
		public static void StartICheckEntityIsVisibility(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F4C0 RID: 128192 RVA: 0x0045CC28 File Offset: 0x0045AE28
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F4C1 RID: 128193 RVA: 0x0045CC33 File Offset: 0x0045AE33
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601F4C2 RID: 128194 RVA: 0x0045CC3E File Offset: 0x0045AE3E
		public static void AddIsVisible(FlatBufferBuilder builder, bool isVisible)
		{
			builder.AddBool(2, isVisible, false);
		}

		// Token: 0x0601F4C3 RID: 128195 RVA: 0x0045CC49 File Offset: 0x0045AE49
		public static Offset<ICheckEntityIsVisibility> EndICheckEntityIsVisibility(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityIsVisibility>(builder.EndTable());
		}

		// Token: 0x0601F4C4 RID: 128196 RVA: 0x0045CC58 File Offset: 0x0045AE58
		public ICheckEntityIsVisibilityT UnPack()
		{
			ICheckEntityIsVisibilityT checkEntityIsVisibilityT = new ICheckEntityIsVisibilityT();
			this.UnPackTo(checkEntityIsVisibilityT);
			return checkEntityIsVisibilityT;
		}

		// Token: 0x0601F4C5 RID: 128197 RVA: 0x0045CC73 File Offset: 0x0045AE73
		public void UnPackTo(ICheckEntityIsVisibilityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.IsVisible = this.IsVisible;
		}

		// Token: 0x0601F4C6 RID: 128198 RVA: 0x0045CC9C File Offset: 0x0045AE9C
		public static Offset<ICheckEntityIsVisibility> Pack(FlatBufferBuilder builder, ICheckEntityIsVisibilityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityIsVisibility>);
			}
			return ICheckEntityIsVisibility.CreateICheckEntityIsVisibility(builder, _o.Type, _o.EntityId, _o.IsVisible);
		}

		// Token: 0x0400DD23 RID: 56611
		private Table __p;
	}
}
