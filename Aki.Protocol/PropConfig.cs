using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DEA RID: 3562
	public sealed class PropConfig : IMessage<PropConfig>, IMessage, IEquatable<PropConfig>, IDeepCloneable<PropConfig>, IBufferMessage
	{
		// Token: 0x06013295 RID: 78485 RVA: 0x002CA74D File Offset: 0x002C894D
		[NullableContext(1)]
		public static PropConfig Create()
		{
			return new PropConfig();
		}

		// Token: 0x17003F91 RID: 16273
		// (get) Token: 0x06013296 RID: 78486 RVA: 0x002CA754 File Offset: 0x002C8954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PropConfig> Parser
		{
			get
			{
				return PropConfig._parser;
			}
		}

		// Token: 0x17003F92 RID: 16274
		// (get) Token: 0x06013297 RID: 78487 RVA: 0x002CA75B File Offset: 0x002C895B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F93 RID: 16275
		// (get) Token: 0x06013298 RID: 78488 RVA: 0x002CA75E File Offset: 0x002C895E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PropConfig.Descriptor;
			}
		}

		// Token: 0x06013299 RID: 78489 RVA: 0x002CA765 File Offset: 0x002C8965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropConfig()
		{
		}

		// Token: 0x0601329A RID: 78490 RVA: 0x002CA76D File Offset: 0x002C896D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropConfig(PropConfig other) : this()
		{
			this.id_ = other.id_;
			this.value_ = other.value_;
			this.isRatio_ = other.isRatio_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601329B RID: 78491 RVA: 0x002CA7AA File Offset: 0x002C89AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropConfig Clone()
		{
			return new PropConfig(this);
		}

		// Token: 0x17003F94 RID: 16276
		// (get) Token: 0x0601329C RID: 78492 RVA: 0x002CA7B2 File Offset: 0x002C89B2
		// (set) Token: 0x0601329D RID: 78493 RVA: 0x002CA7BA File Offset: 0x002C89BA
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

		// Token: 0x17003F95 RID: 16277
		// (get) Token: 0x0601329E RID: 78494 RVA: 0x002CA7C3 File Offset: 0x002C89C3
		// (set) Token: 0x0601329F RID: 78495 RVA: 0x002CA7CB File Offset: 0x002C89CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x17003F96 RID: 16278
		// (get) Token: 0x060132A0 RID: 78496 RVA: 0x002CA7D4 File Offset: 0x002C89D4
		// (set) Token: 0x060132A1 RID: 78497 RVA: 0x002CA7DC File Offset: 0x002C89DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRatio
		{
			get
			{
				return this.isRatio_;
			}
			set
			{
				this.isRatio_ = value;
			}
		}

		// Token: 0x060132A2 RID: 78498 RVA: 0x002CA7E5 File Offset: 0x002C89E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PropConfig);
		}

		// Token: 0x060132A3 RID: 78499 RVA: 0x002CA7F4 File Offset: 0x002C89F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PropConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Value, other.Value) && this.IsRatio == other.IsRatio && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060132A4 RID: 78500 RVA: 0x002CA858 File Offset: 0x002C8A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Value != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Value);
			}
			if (this.IsRatio)
			{
				num ^= this.IsRatio.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060132A5 RID: 78501 RVA: 0x002CA8D0 File Offset: 0x002C8AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060132A6 RID: 78502 RVA: 0x002CA8DD File Offset: 0x002C8ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060132A7 RID: 78503 RVA: 0x002CA8E8 File Offset: 0x002C8AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Value != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Value);
			}
			if (this.IsRatio)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsRatio);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060132A8 RID: 78504 RVA: 0x002CA964 File Offset: 0x002C8B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Value != 0f)
			{
				num += 5;
			}
			if (this.IsRatio)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060132A9 RID: 78505 RVA: 0x002CA9C0 File Offset: 0x002C8BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PropConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Value != 0f)
			{
				this.Value = other.Value;
			}
			if (other.IsRatio)
			{
				this.IsRatio = other.IsRatio;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060132AA RID: 78506 RVA: 0x002CAA29 File Offset: 0x002C8C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060132AB RID: 78507 RVA: 0x002CAA34 File Offset: 0x002C8C34
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
					if (num != 21U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsRatio = input.ReadBool();
						}
					}
					else
					{
						this.Value = input.ReadFloat();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007606 RID: 30214
		private static readonly MessageParser<PropConfig> _parser = new MessageParser<PropConfig>(() => new PropConfig());

		// Token: 0x04007607 RID: 30215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007608 RID: 30216
		public const int IdFieldNumber = 1;

		// Token: 0x04007609 RID: 30217
		private int id_;

		// Token: 0x0400760A RID: 30218
		public const int ValueFieldNumber = 2;

		// Token: 0x0400760B RID: 30219
		private float value_;

		// Token: 0x0400760C RID: 30220
		public const int IsRatioFieldNumber = 3;

		// Token: 0x0400760D RID: 30221
		private bool isRatio_;
	}
}
