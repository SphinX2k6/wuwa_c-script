using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010EF RID: 4335
	[NetMessage(EMessageId.RoleTowerStageRetryRequest)]
	public sealed class RoleTowerStageRetryRequest : IMessage<RoleTowerStageRetryRequest>, IMessage, IEquatable<RoleTowerStageRetryRequest>, IDeepCloneable<RoleTowerStageRetryRequest>, IBufferMessage
	{
		// Token: 0x060172CB RID: 94923 RVA: 0x0035F296 File Offset: 0x0035D496
		[NullableContext(1)]
		public static RoleTowerStageRetryRequest Create()
		{
			return new RoleTowerStageRetryRequest();
		}

		// Token: 0x17004DD6 RID: 19926
		// (get) Token: 0x060172CC RID: 94924 RVA: 0x0035F29D File Offset: 0x0035D49D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DD7 RID: 19927
		// (get) Token: 0x060172CD RID: 94925 RVA: 0x0035F2A0 File Offset: 0x0035D4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerStageRetryRequest.Descriptor;
			}
		}

		// Token: 0x060172CE RID: 94926 RVA: 0x0035F2A7 File Offset: 0x0035D4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageRetryRequest()
		{
		}

		// Token: 0x060172CF RID: 94927 RVA: 0x0035F2B0 File Offset: 0x0035D4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageRetryRequest(RoleTowerStageRetryRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.selection_ = ((other.selection_ != null) ? other.selection_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060172D0 RID: 94928 RVA: 0x0035F2FC File Offset: 0x0035D4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageRetryRequest Clone()
		{
			return new RoleTowerStageRetryRequest(this);
		}

		// Token: 0x17004DD8 RID: 19928
		// (get) Token: 0x060172D1 RID: 94929 RVA: 0x0035F304 File Offset: 0x0035D504
		// (set) Token: 0x060172D2 RID: 94930 RVA: 0x0035F30C File Offset: 0x0035D50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17004DD9 RID: 19929
		// (get) Token: 0x060172D3 RID: 94931 RVA: 0x0035F315 File Offset: 0x0035D515
		// (set) Token: 0x060172D4 RID: 94932 RVA: 0x0035F31D File Offset: 0x0035D51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareSelection Selection
		{
			get
			{
				return this.selection_;
			}
			set
			{
				this.selection_ = value;
			}
		}

		// Token: 0x060172D5 RID: 94933 RVA: 0x0035F326 File Offset: 0x0035D526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerStageRetryRequest);
		}

		// Token: 0x060172D6 RID: 94934 RVA: 0x0035F334 File Offset: 0x0035D534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerStageRetryRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this.Selection, other.Selection) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060172D7 RID: 94935 RVA: 0x0035F384 File Offset: 0x0035D584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.selection_ != null)
			{
				num ^= this.Selection.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060172D8 RID: 94936 RVA: 0x0035F3D9 File Offset: 0x0035D5D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060172D9 RID: 94937 RVA: 0x0035F3E6 File Offset: 0x0035D5E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060172DA RID: 94938 RVA: 0x0035F3F0 File Offset: 0x0035D5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.selection_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Selection);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060172DB RID: 94939 RVA: 0x0035F44C File Offset: 0x0035D64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.selection_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Selection);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060172DC RID: 94940 RVA: 0x0035F4A4 File Offset: 0x0035D6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerStageRetryRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.selection_ != null)
			{
				if (this.selection_ == null)
				{
					this.Selection = new RoleTowerPrepareSelection();
				}
				this.Selection.MergeFrom(other.Selection);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060172DD RID: 94941 RVA: 0x0035F50C File Offset: 0x0035D70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060172DE RID: 94942 RVA: 0x0035F518 File Offset: 0x0035D718
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
				if (num != 10U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChallengeId = input.ReadInt32();
					}
				}
				else
				{
					if (this.selection_ == null)
					{
						this.Selection = new RoleTowerPrepareSelection();
					}
					input.ReadMessage(this.Selection);
				}
			}
		}

		// Token: 0x04008AAE RID: 35502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AAF RID: 35503
		public const int ChallengeIdFieldNumber = 4;

		// Token: 0x04008AB0 RID: 35504
		private int challengeId_;

		// Token: 0x04008AB1 RID: 35505
		public const int SelectionFieldNumber = 1;

		// Token: 0x04008AB2 RID: 35506
		private RoleTowerPrepareSelection selection_;
	}
}
