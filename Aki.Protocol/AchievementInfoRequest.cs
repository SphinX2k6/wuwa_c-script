using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000060 RID: 96
	[NetMessage(EMessageId.AchievementInfoRequest)]
	public sealed class AchievementInfoRequest : IMessage<AchievementInfoRequest>, IMessage, IEquatable<AchievementInfoRequest>, IDeepCloneable<AchievementInfoRequest>, IBufferMessage
	{
		// Token: 0x06001617 RID: 5655 RVA: 0x0003A484 File Offset: 0x00038684
		[NullableContext(1)]
		public static AchievementInfoRequest Create()
		{
			return new AchievementInfoRequest();
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x0003A48B File Offset: 0x0003868B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x0003A48E File Offset: 0x0003868E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0003A495 File Offset: 0x00038695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementInfoRequest()
		{
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x0003A49D File Offset: 0x0003869D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementInfoRequest(AchievementInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x0003A4B6 File Offset: 0x000386B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementInfoRequest Clone()
		{
			return new AchievementInfoRequest(this);
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x0003A4BE File Offset: 0x000386BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementInfoRequest);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x0003A4CC File Offset: 0x000386CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x0003A4EC File Offset: 0x000386EC
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

		// Token: 0x06001620 RID: 5664 RVA: 0x0003A512 File Offset: 0x00038712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0003A51F File Offset: 0x0003871F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0003A528 File Offset: 0x00038728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0003A540 File Offset: 0x00038740
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

		// Token: 0x06001624 RID: 5668 RVA: 0x0003A566 File Offset: 0x00038766
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

		// Token: 0x06001625 RID: 5669 RVA: 0x0003A583 File Offset: 0x00038783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x0003A58C File Offset: 0x0003878C
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

		// Token: 0x040020CC RID: 8396
		private UnknownFieldSet _unknownFields;
	}
}
