using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BBB RID: 3003
	[NetMessage(EMessageId.ParkourChallengeRequest)]
	public sealed class ParkourChallengeRequest : IMessage<ParkourChallengeRequest>, IMessage, IEquatable<ParkourChallengeRequest>, IDeepCloneable<ParkourChallengeRequest>, IBufferMessage
	{
		// Token: 0x06010472 RID: 66674 RVA: 0x0026033C File Offset: 0x0025E53C
		[NullableContext(1)]
		public static ParkourChallengeRequest Create()
		{
			return new ParkourChallengeRequest();
		}

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x06010473 RID: 66675 RVA: 0x00260343 File Offset: 0x0025E543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x06010474 RID: 66676 RVA: 0x00260346 File Offset: 0x0025E546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeRequest.Descriptor;
			}
		}

		// Token: 0x06010475 RID: 66677 RVA: 0x0026034D File Offset: 0x0025E54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeRequest()
		{
		}

		// Token: 0x06010476 RID: 66678 RVA: 0x00260355 File Offset: 0x0025E555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeRequest(ParkourChallengeRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010477 RID: 66679 RVA: 0x0026036E File Offset: 0x0025E56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeRequest Clone()
		{
			return new ParkourChallengeRequest(this);
		}

		// Token: 0x06010478 RID: 66680 RVA: 0x00260376 File Offset: 0x0025E576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeRequest);
		}

		// Token: 0x06010479 RID: 66681 RVA: 0x00260384 File Offset: 0x0025E584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601047A RID: 66682 RVA: 0x002603A4 File Offset: 0x0025E5A4
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

		// Token: 0x0601047B RID: 66683 RVA: 0x002603CA File Offset: 0x0025E5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601047C RID: 66684 RVA: 0x002603D7 File Offset: 0x0025E5D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601047D RID: 66685 RVA: 0x002603E0 File Offset: 0x0025E5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601047E RID: 66686 RVA: 0x002603F8 File Offset: 0x0025E5F8
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

		// Token: 0x0601047F RID: 66687 RVA: 0x0026041E File Offset: 0x0025E61E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ParkourChallengeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010480 RID: 66688 RVA: 0x0026043B File Offset: 0x0025E63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010481 RID: 66689 RVA: 0x00260444 File Offset: 0x0025E644
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

		// Token: 0x0400678D RID: 26509
		private UnknownFieldSet _unknownFields;
	}
}
