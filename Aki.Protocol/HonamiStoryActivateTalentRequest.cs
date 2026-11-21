using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000748 RID: 1864
	[NetMessage(EMessageId.HonamiStoryActivateTalentRequest)]
	public sealed class HonamiStoryActivateTalentRequest : IMessage<HonamiStoryActivateTalentRequest>, IMessage, IEquatable<HonamiStoryActivateTalentRequest>, IDeepCloneable<HonamiStoryActivateTalentRequest>, IBufferMessage
	{
		// Token: 0x0600A938 RID: 43320 RVA: 0x00197BB8 File Offset: 0x00195DB8
		[NullableContext(1)]
		public static HonamiStoryActivateTalentRequest Create()
		{
			return new HonamiStoryActivateTalentRequest();
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x0600A939 RID: 43321 RVA: 0x00197BBF File Offset: 0x00195DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x0600A93A RID: 43322 RVA: 0x00197BC2 File Offset: 0x00195DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryActivateTalentRequest.Descriptor;
			}
		}

		// Token: 0x0600A93B RID: 43323 RVA: 0x00197BC9 File Offset: 0x00195DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivateTalentRequest()
		{
		}

		// Token: 0x0600A93C RID: 43324 RVA: 0x00197BD1 File Offset: 0x00195DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivateTalentRequest(HonamiStoryActivateTalentRequest other) : this()
		{
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A93D RID: 43325 RVA: 0x00197BF6 File Offset: 0x00195DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivateTalentRequest Clone()
		{
			return new HonamiStoryActivateTalentRequest(this);
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x0600A93E RID: 43326 RVA: 0x00197BFE File Offset: 0x00195DFE
		// (set) Token: 0x0600A93F RID: 43327 RVA: 0x00197C06 File Offset: 0x00195E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalentId
		{
			get
			{
				return this.talentId_;
			}
			set
			{
				this.talentId_ = value;
			}
		}

		// Token: 0x0600A940 RID: 43328 RVA: 0x00197C0F File Offset: 0x00195E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryActivateTalentRequest);
		}

		// Token: 0x0600A941 RID: 43329 RVA: 0x00197C1D File Offset: 0x00195E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryActivateTalentRequest other)
		{
			return other != null && (other == this || (this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A942 RID: 43330 RVA: 0x00197C4C File Offset: 0x00195E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalentId != 0)
			{
				num ^= this.TalentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A943 RID: 43331 RVA: 0x00197C8B File Offset: 0x00195E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A944 RID: 43332 RVA: 0x00197C98 File Offset: 0x00195E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A945 RID: 43333 RVA: 0x00197CA1 File Offset: 0x00195EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A946 RID: 43334 RVA: 0x00197CD4 File Offset: 0x00195ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A947 RID: 43335 RVA: 0x00197D12 File Offset: 0x00195F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryActivateTalentRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalentId != 0)
			{
				this.TalentId = other.TalentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A948 RID: 43336 RVA: 0x00197D43 File Offset: 0x00195F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A949 RID: 43337 RVA: 0x00197D4C File Offset: 0x00195F4C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TalentId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004D7B RID: 19835
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D7C RID: 19836
		public const int TalentIdFieldNumber = 8;

		// Token: 0x04004D7D RID: 19837
		private int talentId_;
	}
}
