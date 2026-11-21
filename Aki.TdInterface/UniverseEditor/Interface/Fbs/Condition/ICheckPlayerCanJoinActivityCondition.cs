using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FAD RID: 20397
	public struct ICheckPlayerCanJoinActivityCondition : IFlatbufferObject
	{
		// Token: 0x170091E3 RID: 37347
		// (get) Token: 0x0601FC9D RID: 130205 RVA: 0x0046AA8A File Offset: 0x00468C8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FC9E RID: 130206 RVA: 0x0046AA97 File Offset: 0x00468C97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FC9F RID: 130207 RVA: 0x0046AAA0 File Offset: 0x00468CA0
		public static ICheckPlayerCanJoinActivityCondition GetRootAsICheckPlayerCanJoinActivityCondition(ByteBuffer _bb)
		{
			return ICheckPlayerCanJoinActivityCondition.GetRootAsICheckPlayerCanJoinActivityCondition(_bb, default(ICheckPlayerCanJoinActivityCondition));
		}

		// Token: 0x0601FCA0 RID: 130208 RVA: 0x0046AABC File Offset: 0x00468CBC
		public static ICheckPlayerCanJoinActivityCondition GetRootAsICheckPlayerCanJoinActivityCondition(ByteBuffer _bb, ICheckPlayerCanJoinActivityCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FCA1 RID: 130209 RVA: 0x0046AAD9 File Offset: 0x00468CD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FCA2 RID: 130210 RVA: 0x0046AAE8 File Offset: 0x00468CE8
		public ICheckPlayerCanJoinActivityCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091E4 RID: 37348
		// (get) Token: 0x0601FCA3 RID: 130211 RVA: 0x0046AAF8 File Offset: 0x00468CF8
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

		// Token: 0x170091E5 RID: 37349
		// (get) Token: 0x0601FCA4 RID: 130212 RVA: 0x0046AB34 File Offset: 0x00468D34
		public ICheckPlayerCanJoinRogue? Config
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICheckPlayerCanJoinRogue?(default(ICheckPlayerCanJoinRogue).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601FCA5 RID: 130213 RVA: 0x0046AB91 File Offset: 0x00468D91
		public static Offset<ICheckPlayerCanJoinActivityCondition> CreateICheckPlayerCanJoinActivityCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<ICheckPlayerCanJoinRogue> ConfigOffset = default(Offset<ICheckPlayerCanJoinRogue>))
		{
			builder.StartTable(2);
			ICheckPlayerCanJoinActivityCondition.AddConfig(builder, ConfigOffset);
			ICheckPlayerCanJoinActivityCondition.AddType(builder, Type);
			return ICheckPlayerCanJoinActivityCondition.EndICheckPlayerCanJoinActivityCondition(builder);
		}

		// Token: 0x0601FCA6 RID: 130214 RVA: 0x0046ABAE File Offset: 0x00468DAE
		public static void StartICheckPlayerCanJoinActivityCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FCA7 RID: 130215 RVA: 0x0046ABB7 File Offset: 0x00468DB7
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FCA8 RID: 130216 RVA: 0x0046ABC2 File Offset: 0x00468DC2
		public static void AddConfig(FlatBufferBuilder builder, Offset<ICheckPlayerCanJoinRogue> configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x0601FCA9 RID: 130217 RVA: 0x0046ABD2 File Offset: 0x00468DD2
		public static Offset<ICheckPlayerCanJoinActivityCondition> EndICheckPlayerCanJoinActivityCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerCanJoinActivityCondition>(builder.EndTable());
		}

		// Token: 0x0601FCAA RID: 130218 RVA: 0x0046ABE0 File Offset: 0x00468DE0
		public ICheckPlayerCanJoinActivityConditionT UnPack()
		{
			ICheckPlayerCanJoinActivityConditionT checkPlayerCanJoinActivityConditionT = new ICheckPlayerCanJoinActivityConditionT();
			this.UnPackTo(checkPlayerCanJoinActivityConditionT);
			return checkPlayerCanJoinActivityConditionT;
		}

		// Token: 0x0601FCAB RID: 130219 RVA: 0x0046ABFC File Offset: 0x00468DFC
		public void UnPackTo(ICheckPlayerCanJoinActivityConditionT _o)
		{
			_o.Type = this.Type;
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x0601FCAC RID: 130220 RVA: 0x0046AC44 File Offset: 0x00468E44
		public static Offset<ICheckPlayerCanJoinActivityCondition> Pack(FlatBufferBuilder builder, ICheckPlayerCanJoinActivityConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerCanJoinActivityCondition>);
			}
			Offset<ICheckPlayerCanJoinRogue> configOffset = (_o.Config == null) ? default(Offset<ICheckPlayerCanJoinRogue>) : ICheckPlayerCanJoinRogue.Pack(builder, _o.Config);
			return ICheckPlayerCanJoinActivityCondition.CreateICheckPlayerCanJoinActivityCondition(builder, _o.Type, configOffset);
		}

		// Token: 0x0400DE4D RID: 56909
		private Table __p;
	}
}
