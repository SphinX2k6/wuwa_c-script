using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200018F RID: 399
	[NetMessage(EMessageId.BeControlledRequest)]
	public sealed class BeControlledRequest : IMessage<BeControlledRequest>, IMessage, IEquatable<BeControlledRequest>, IDeepCloneable<BeControlledRequest>, IBufferMessage
	{
		// Token: 0x06002FE8 RID: 12264 RVA: 0x0007AD65 File Offset: 0x00078F65
		[NullableContext(1)]
		public static BeControlledRequest Create()
		{
			return new BeControlledRequest();
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06002FE9 RID: 12265 RVA: 0x0007AD6C File Offset: 0x00078F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06002FEA RID: 12266 RVA: 0x0007AD6F File Offset: 0x00078F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledRequest.Descriptor;
			}
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x0007AD76 File Offset: 0x00078F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledRequest()
		{
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x0007AD7E File Offset: 0x00078F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledRequest(BeControlledRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isControl_ = other.isControl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x0007ADAF File Offset: 0x00078FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledRequest Clone()
		{
			return new BeControlledRequest(this);
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06002FEE RID: 12270 RVA: 0x0007ADB7 File Offset: 0x00078FB7
		// (set) Token: 0x06002FEF RID: 12271 RVA: 0x0007ADBF File Offset: 0x00078FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x0007ADC8 File Offset: 0x00078FC8
		// (set) Token: 0x06002FF1 RID: 12273 RVA: 0x0007ADD0 File Offset: 0x00078FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsControl
		{
			get
			{
				return this.isControl_;
			}
			set
			{
				this.isControl_ = value;
			}
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x0007ADD9 File Offset: 0x00078FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledRequest);
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x0007ADE7 File Offset: 0x00078FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsControl == other.IsControl && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x0007AE28 File Offset: 0x00079028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsControl)
			{
				num ^= this.IsControl.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x0007AE80 File Offset: 0x00079080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x0007AE8D File Offset: 0x0007908D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x0007AE98 File Offset: 0x00079098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsControl)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsControl);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x0007AEF4 File Offset: 0x000790F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsControl)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x0007AF40 File Offset: 0x00079140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsControl)
			{
				this.IsControl = other.IsControl;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x0007AF90 File Offset: 0x00079190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x0007AF9C File Offset: 0x0007919C
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
				if (num != 112U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsControl = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002926 RID: 10534
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002927 RID: 10535
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04002928 RID: 10536
		private long entityId_;

		// Token: 0x04002929 RID: 10537
		public const int IsControlFieldNumber = 15;

		// Token: 0x0400292A RID: 10538
		private bool isControl_;
	}
}
