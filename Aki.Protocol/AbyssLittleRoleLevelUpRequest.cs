using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200002B RID: 43
	[NetMessage(EMessageId.AbyssLittleRoleLevelUpRequest)]
	public sealed class AbyssLittleRoleLevelUpRequest : IMessage<AbyssLittleRoleLevelUpRequest>, IMessage, IEquatable<AbyssLittleRoleLevelUpRequest>, IDeepCloneable<AbyssLittleRoleLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0600121A RID: 4634 RVA: 0x000320E5 File Offset: 0x000302E5
		[NullableContext(1)]
		public static AbyssLittleRoleLevelUpRequest Create()
		{
			return new AbyssLittleRoleLevelUpRequest();
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x000320EC File Offset: 0x000302EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x000320EF File Offset: 0x000302EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssLittleRoleLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x000320F6 File Offset: 0x000302F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLittleRoleLevelUpRequest()
		{
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x000320FE File Offset: 0x000302FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLittleRoleLevelUpRequest(AbyssLittleRoleLevelUpRequest other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0003212F File Offset: 0x0003032F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLittleRoleLevelUpRequest Clone()
		{
			return new AbyssLittleRoleLevelUpRequest(this);
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x00032137 File Offset: 0x00030337
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x0003213F File Offset: 0x0003033F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x00032148 File Offset: 0x00030348
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x00032150 File Offset: 0x00030350
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

		// Token: 0x06001224 RID: 4644 RVA: 0x00032159 File Offset: 0x00030359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssLittleRoleLevelUpRequest);
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00032167 File Offset: 0x00030367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssLittleRoleLevelUpRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x000321A8 File Offset: 0x000303A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
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

		// Token: 0x06001227 RID: 4647 RVA: 0x00032200 File Offset: 0x00030400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0003220D File Offset: 0x0003040D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00032218 File Offset: 0x00030418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Level);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00032274 File Offset: 0x00030474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
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

		// Token: 0x0600122B RID: 4651 RVA: 0x000322CC File Offset: 0x000304CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssLittleRoleLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0003231C File Offset: 0x0003051C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00032328 File Offset: 0x00030528
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
				if (num != 24U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001FFD RID: 8189
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FFE RID: 8190
		public const int IdFieldNumber = 5;

		// Token: 0x04001FFF RID: 8191
		private int id_;

		// Token: 0x04002000 RID: 8192
		public const int LevelFieldNumber = 3;

		// Token: 0x04002001 RID: 8193
		private int level_;
	}
}
