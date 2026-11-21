using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000192 RID: 402
	[NetMessage(EMessageId.BeControlledShowRequest)]
	public sealed class BeControlledShowRequest : IMessage<BeControlledShowRequest>, IMessage, IEquatable<BeControlledShowRequest>, IDeepCloneable<BeControlledShowRequest>, IBufferMessage
	{
		// Token: 0x06003024 RID: 12324 RVA: 0x0007B50F File Offset: 0x0007970F
		[NullableContext(1)]
		public static BeControlledShowRequest Create()
		{
			return new BeControlledShowRequest();
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x0007B516 File Offset: 0x00079716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x0007B519 File Offset: 0x00079719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledShowRequest.Descriptor;
			}
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x0007B520 File Offset: 0x00079720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowRequest()
		{
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x0007B528 File Offset: 0x00079728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowRequest(BeControlledShowRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isShow_ = other.isShow_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x0007B559 File Offset: 0x00079759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledShowRequest Clone()
		{
			return new BeControlledShowRequest(this);
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600302A RID: 12330 RVA: 0x0007B561 File Offset: 0x00079761
		// (set) Token: 0x0600302B RID: 12331 RVA: 0x0007B569 File Offset: 0x00079769
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

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600302C RID: 12332 RVA: 0x0007B572 File Offset: 0x00079772
		// (set) Token: 0x0600302D RID: 12333 RVA: 0x0007B57A File Offset: 0x0007977A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x0007B583 File Offset: 0x00079783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledShowRequest);
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x0007B591 File Offset: 0x00079791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledShowRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsShow == other.IsShow && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x0007B5D0 File Offset: 0x000797D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x0007B628 File Offset: 0x00079828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x0007B635 File Offset: 0x00079835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x0007B640 File Offset: 0x00079840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShow)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsShow);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x0007B69C File Offset: 0x0007989C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsShow)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x0007B6E8 File Offset: 0x000798E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledShowRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x0007B738 File Offset: 0x00079938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x0007B744 File Offset: 0x00079944
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
				if (num != 96U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.IsShow = input.ReadBool();
				}
			}
		}

		// Token: 0x04002935 RID: 10549
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002936 RID: 10550
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04002937 RID: 10551
		private long entityId_;

		// Token: 0x04002938 RID: 10552
		public const int IsShowFieldNumber = 12;

		// Token: 0x04002939 RID: 10553
		private bool isShow_;
	}
}
