using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200128A RID: 4746
	public sealed class SrvFighterSkillInfo : IMessage<SrvFighterSkillInfo>, IMessage, IEquatable<SrvFighterSkillInfo>, IDeepCloneable<SrvFighterSkillInfo>, IBufferMessage
	{
		// Token: 0x0601945C RID: 103516 RVA: 0x003ACF2A File Offset: 0x003AB12A
		[NullableContext(1)]
		public static SrvFighterSkillInfo Create()
		{
			return new SrvFighterSkillInfo();
		}

		// Token: 0x17005540 RID: 21824
		// (get) Token: 0x0601945D RID: 103517 RVA: 0x003ACF31 File Offset: 0x003AB131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SrvFighterSkillInfo> Parser
		{
			get
			{
				return SrvFighterSkillInfo._parser;
			}
		}

		// Token: 0x17005541 RID: 21825
		// (get) Token: 0x0601945E RID: 103518 RVA: 0x003ACF38 File Offset: 0x003AB138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005542 RID: 21826
		// (get) Token: 0x0601945F RID: 103519 RVA: 0x003ACF3B File Offset: 0x003AB13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SrvFighterSkillInfo.Descriptor;
			}
		}

		// Token: 0x06019460 RID: 103520 RVA: 0x003ACF42 File Offset: 0x003AB142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterSkillInfo()
		{
		}

		// Token: 0x06019461 RID: 103521 RVA: 0x003ACF4A File Offset: 0x003AB14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterSkillInfo(SrvFighterSkillInfo other) : this()
		{
			this.skillId_ = other.skillId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019462 RID: 103522 RVA: 0x003ACF7B File Offset: 0x003AB17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterSkillInfo Clone()
		{
			return new SrvFighterSkillInfo(this);
		}

		// Token: 0x17005543 RID: 21827
		// (get) Token: 0x06019463 RID: 103523 RVA: 0x003ACF83 File Offset: 0x003AB183
		// (set) Token: 0x06019464 RID: 103524 RVA: 0x003ACF8B File Offset: 0x003AB18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17005544 RID: 21828
		// (get) Token: 0x06019465 RID: 103525 RVA: 0x003ACF94 File Offset: 0x003AB194
		// (set) Token: 0x06019466 RID: 103526 RVA: 0x003ACF9C File Offset: 0x003AB19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06019467 RID: 103527 RVA: 0x003ACFA5 File Offset: 0x003AB1A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SrvFighterSkillInfo);
		}

		// Token: 0x06019468 RID: 103528 RVA: 0x003ACFB3 File Offset: 0x003AB1B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SrvFighterSkillInfo other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019469 RID: 103529 RVA: 0x003ACFF4 File Offset: 0x003AB1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601946A RID: 103530 RVA: 0x003AD04C File Offset: 0x003AB24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601946B RID: 103531 RVA: 0x003AD059 File Offset: 0x003AB259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601946C RID: 103532 RVA: 0x003AD064 File Offset: 0x003AB264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601946D RID: 103533 RVA: 0x003AD0BC File Offset: 0x003AB2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601946E RID: 103534 RVA: 0x003AD114 File Offset: 0x003AB314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SrvFighterSkillInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601946F RID: 103535 RVA: 0x003AD164 File Offset: 0x003AB364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019470 RID: 103536 RVA: 0x003AD170 File Offset: 0x003AB370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040094A0 RID: 38048
		private static readonly MessageParser<SrvFighterSkillInfo> _parser = new MessageParser<SrvFighterSkillInfo>(() => new SrvFighterSkillInfo());

		// Token: 0x040094A1 RID: 38049
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094A2 RID: 38050
		public const int SkillIdFieldNumber = 1;

		// Token: 0x040094A3 RID: 38051
		private int skillId_;

		// Token: 0x040094A4 RID: 38052
		public const int LevelFieldNumber = 2;

		// Token: 0x040094A5 RID: 38053
		private int level_;
	}
}
