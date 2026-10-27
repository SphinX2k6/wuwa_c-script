using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F6B RID: 3947
	[NetMessage(EMessageId.RoadBookFullRewardRequest)]
	public sealed class RoadBookFullRewardRequest : IMessage<RoadBookFullRewardRequest>, IMessage, IEquatable<RoadBookFullRewardRequest>, IDeepCloneable<RoadBookFullRewardRequest>, IBufferMessage
	{
		// Token: 0x060151A9 RID: 86441 RVA: 0x0030F62D File Offset: 0x0030D82D
		[NullableContext(1)]
		public static RoadBookFullRewardRequest Create()
		{
			return new RoadBookFullRewardRequest();
		}

		// Token: 0x17004633 RID: 17971
		// (get) Token: 0x060151AA RID: 86442 RVA: 0x0030F634 File Offset: 0x0030D834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004634 RID: 17972
		// (get) Token: 0x060151AB RID: 86443 RVA: 0x0030F637 File Offset: 0x0030D837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookFullRewardRequest.Descriptor;
			}
		}

		// Token: 0x060151AC RID: 86444 RVA: 0x0030F63E File Offset: 0x0030D83E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookFullRewardRequest()
		{
		}

		// Token: 0x060151AD RID: 86445 RVA: 0x0030F646 File Offset: 0x0030D846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookFullRewardRequest(RoadBookFullRewardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060151AE RID: 86446 RVA: 0x0030F65F File Offset: 0x0030D85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookFullRewardRequest Clone()
		{
			return new RoadBookFullRewardRequest(this);
		}

		// Token: 0x060151AF RID: 86447 RVA: 0x0030F667 File Offset: 0x0030D867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookFullRewardRequest);
		}

		// Token: 0x060151B0 RID: 86448 RVA: 0x0030F675 File Offset: 0x0030D875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookFullRewardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060151B1 RID: 86449 RVA: 0x0030F694 File Offset: 0x0030D894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060151B2 RID: 86450 RVA: 0x0030F6BA File Offset: 0x0030D8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060151B3 RID: 86451 RVA: 0x0030F6C7 File Offset: 0x0030D8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060151B4 RID: 86452 RVA: 0x0030F6D0 File Offset: 0x0030D8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060151B5 RID: 86453 RVA: 0x0030F6E8 File Offset: 0x0030D8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060151B6 RID: 86454 RVA: 0x0030F70E File Offset: 0x0030D90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookFullRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060151B7 RID: 86455 RVA: 0x0030F72B File Offset: 0x0030D92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060151B8 RID: 86456 RVA: 0x0030F734 File Offset: 0x0030D934
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F0B RID: 32523
		private UnknownFieldSet _unknownFields;
	}
}
