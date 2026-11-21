using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000416 RID: 1046
	[NetMessage(EMessageId.ElementalAbilityUpdateNotify)]
	public sealed class ElementalAbilityUpdateNotify : IMessage<ElementalAbilityUpdateNotify>, IMessage, IEquatable<ElementalAbilityUpdateNotify>, IDeepCloneable<ElementalAbilityUpdateNotify>, IBufferMessage
	{
		// Token: 0x06006509 RID: 25865 RVA: 0x000F396F File Offset: 0x000F1B6F
		[NullableContext(1)]
		public static ElementalAbilityUpdateNotify Create()
		{
			return new ElementalAbilityUpdateNotify();
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x0600650A RID: 25866 RVA: 0x000F3976 File Offset: 0x000F1B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x0600650B RID: 25867 RVA: 0x000F3979 File Offset: 0x000F1B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ElementalAbilityUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x000F3980 File Offset: 0x000F1B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementalAbilityUpdateNotify()
		{
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x000F3993 File Offset: 0x000F1B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementalAbilityUpdateNotify(ElementalAbilityUpdateNotify other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this.elementalType_ = other.elementalType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x000F39C4 File Offset: 0x000F1BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementalAbilityUpdateNotify Clone()
		{
			return new ElementalAbilityUpdateNotify(this);
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x0600650F RID: 25871 RVA: 0x000F39CC File Offset: 0x000F1BCC
		// (set) Token: 0x06006510 RID: 25872 RVA: 0x000F39D4 File Offset: 0x000F1BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06006511 RID: 25873 RVA: 0x000F39DD File Offset: 0x000F1BDD
		// (set) Token: 0x06006512 RID: 25874 RVA: 0x000F39E5 File Offset: 0x000F1BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ElementalType
		{
			get
			{
				return this.elementalType_;
			}
			set
			{
				this.elementalType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06006513 RID: 25875 RVA: 0x000F39F8 File Offset: 0x000F1BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ElementalAbilityUpdateNotify);
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x000F3A08 File Offset: 0x000F1C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ElementalAbilityUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && !(this.ElementalType != other.ElementalType) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x000F3A58 File Offset: 0x000F1C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this.ElementalType.Length != 0)
			{
				num ^= this.ElementalType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006516 RID: 25878 RVA: 0x000F3AB2 File Offset: 0x000F1CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006517 RID: 25879 RVA: 0x000F3ABF File Offset: 0x000F1CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006518 RID: 25880 RVA: 0x000F3AC8 File Offset: 0x000F1CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityIncId);
			}
			if (this.ElementalType.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.ElementalType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006519 RID: 25881 RVA: 0x000F3B28 File Offset: 0x000F1D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this.ElementalType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ElementalType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600651A RID: 25882 RVA: 0x000F3B84 File Offset: 0x000F1D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ElementalAbilityUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			if (other.ElementalType.Length != 0)
			{
				this.ElementalType = other.ElementalType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600651B RID: 25883 RVA: 0x000F3BD9 File Offset: 0x000F1DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x000F3BE4 File Offset: 0x000F1DE4
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
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ElementalType = input.ReadString();
					}
				}
				else
				{
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400391A RID: 14618
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400391B RID: 14619
		public const int EntityIncIdFieldNumber = 3;

		// Token: 0x0400391C RID: 14620
		private long entityIncId_;

		// Token: 0x0400391D RID: 14621
		public const int ElementalTypeFieldNumber = 5;

		// Token: 0x0400391E RID: 14622
		private string elementalType_ = "";
	}
}
