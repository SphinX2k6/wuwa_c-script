using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000061 RID: 97
	[NetMessage(EMessageId.AchievementInfoRequest)]
	public sealed class AchievementInfoRequest : IMessage<AchievementInfoRequest>, IMessage, IEquatable<AchievementInfoRequest>, IDeepCloneable<AchievementInfoRequest>, IBufferMessage
	{
		// Token: 0x0600165A RID: 5722 RVA: 0x0003AE28 File Offset: 0x00039028
		[NullableContext(1)]
		public static AchievementInfoRequest Create()
		{
			return new AchievementInfoRequest();
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x0003AE2F File Offset: 0x0003902F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x0003AE32 File Offset: 0x00039032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0003AE39 File Offset: 0x00039039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementInfoRequest()
		{
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0003AE41 File Offset: 0x00039041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementInfoRequest(AchievementInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0003AE5A File Offset: 0x0003905A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementInfoRequest Clone()
		{
			return new AchievementInfoRequest(this);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x0003AE62 File Offset: 0x00039062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementInfoRequest);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0003AE70 File Offset: 0x00039070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0003AE90 File Offset: 0x00039090
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

		// Token: 0x06001663 RID: 5731 RVA: 0x0003AEB6 File Offset: 0x000390B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0003AEC3 File Offset: 0x000390C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x0003AECC File Offset: 0x000390CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0003AEE4 File Offset: 0x000390E4
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

		// Token: 0x06001667 RID: 5735 RVA: 0x0003AF0A File Offset: 0x0003910A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0003AF27 File Offset: 0x00039127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x0003AF30 File Offset: 0x00039130
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

		// Token: 0x0400212B RID: 8491
		private UnknownFieldSet _unknownFields;
	}
}
