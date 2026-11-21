using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000204 RID: 516
	[NetMessage(EMessageId.BuffEffectRequest)]
	public sealed class BuffEffectRequest : IMessage<BuffEffectRequest>, IMessage, IEquatable<BuffEffectRequest>, IDeepCloneable<BuffEffectRequest>, IBufferMessage
	{
		// Token: 0x06003947 RID: 14663 RVA: 0x0008F314 File Offset: 0x0008D514
		[NullableContext(1)]
		public static BuffEffectRequest Create()
		{
			return new BuffEffectRequest();
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x0008F31B File Offset: 0x0008D51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x0008F31E File Offset: 0x0008D51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffEffectRequest.Descriptor;
			}
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x0008F325 File Offset: 0x0008D525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectRequest()
		{
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x0008F32D File Offset: 0x0008D52D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectRequest(BuffEffectRequest other) : this()
		{
			this.handleId_ = other.handleId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x0008F35E File Offset: 0x0008D55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffEffectRequest Clone()
		{
			return new BuffEffectRequest(this);
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x0600394D RID: 14669 RVA: 0x0008F366 File Offset: 0x0008D566
		// (set) Token: 0x0600394E RID: 14670 RVA: 0x0008F36E File Offset: 0x0008D56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandleId
		{
			get
			{
				return this.handleId_;
			}
			set
			{
				this.handleId_ = value;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x0600394F RID: 14671 RVA: 0x0008F377 File Offset: 0x0008D577
		// (set) Token: 0x06003950 RID: 14672 RVA: 0x0008F37F File Offset: 0x0008D57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x0008F388 File Offset: 0x0008D588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffEffectRequest);
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x0008F396 File Offset: 0x0008D596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffEffectRequest other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x0008F3D4 File Offset: 0x0008D5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandleId != 0)
			{
				num ^= this.HandleId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x0008F42C File Offset: 0x0008D62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x0008F439 File Offset: 0x0008D639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x0008F444 File Offset: 0x0008D644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HandleId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x0008F4A0 File Offset: 0x0008D6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandleId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x0008F4F8 File Offset: 0x0008D6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffEffectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandleId != 0)
			{
				this.HandleId = other.HandleId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x0008F548 File Offset: 0x0008D748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x0008F554 File Offset: 0x0008D754
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.HandleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002BC4 RID: 11204
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BC5 RID: 11205
		public const int HandleIdFieldNumber = 3;

		// Token: 0x04002BC6 RID: 11206
		private int handleId_;

		// Token: 0x04002BC7 RID: 11207
		public const int IndexFieldNumber = 12;

		// Token: 0x04002BC8 RID: 11208
		private int index_;
	}
}
