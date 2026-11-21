using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200099F RID: 2463
	[NetMessage(EMessageId.MatchChangeReadyNotify)]
	public sealed class MatchChangeReadyNotify : IMessage<MatchChangeReadyNotify>, IMessage, IEquatable<MatchChangeReadyNotify>, IDeepCloneable<MatchChangeReadyNotify>, IBufferMessage
	{
		// Token: 0x0600D897 RID: 55447 RVA: 0x001FD775 File Offset: 0x001FB975
		[NullableContext(1)]
		public static MatchChangeReadyNotify Create()
		{
			return new MatchChangeReadyNotify();
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x0600D898 RID: 55448 RVA: 0x001FD77C File Offset: 0x001FB97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x0600D899 RID: 55449 RVA: 0x001FD77F File Offset: 0x001FB97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeReadyNotify.Descriptor;
			}
		}

		// Token: 0x0600D89A RID: 55450 RVA: 0x001FD786 File Offset: 0x001FB986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyNotify()
		{
		}

		// Token: 0x0600D89B RID: 55451 RVA: 0x001FD78E File Offset: 0x001FB98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyNotify(MatchChangeReadyNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.isReady_ = other.isReady_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D89C RID: 55452 RVA: 0x001FD7BF File Offset: 0x001FB9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyNotify Clone()
		{
			return new MatchChangeReadyNotify(this);
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x0600D89D RID: 55453 RVA: 0x001FD7C7 File Offset: 0x001FB9C7
		// (set) Token: 0x0600D89E RID: 55454 RVA: 0x001FD7CF File Offset: 0x001FB9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x0600D89F RID: 55455 RVA: 0x001FD7D8 File Offset: 0x001FB9D8
		// (set) Token: 0x0600D8A0 RID: 55456 RVA: 0x001FD7E0 File Offset: 0x001FB9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReady
		{
			get
			{
				return this.isReady_;
			}
			set
			{
				this.isReady_ = value;
			}
		}

		// Token: 0x0600D8A1 RID: 55457 RVA: 0x001FD7E9 File Offset: 0x001FB9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeReadyNotify);
		}

		// Token: 0x0600D8A2 RID: 55458 RVA: 0x001FD7F7 File Offset: 0x001FB9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeReadyNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IsReady == other.IsReady && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D8A3 RID: 55459 RVA: 0x001FD838 File Offset: 0x001FBA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IsReady)
			{
				num ^= this.IsReady.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D8A4 RID: 55460 RVA: 0x001FD890 File Offset: 0x001FBA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D8A5 RID: 55461 RVA: 0x001FD89D File Offset: 0x001FBA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8A6 RID: 55462 RVA: 0x001FD8A8 File Offset: 0x001FBAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IsReady)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsReady);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D8A7 RID: 55463 RVA: 0x001FD900 File Offset: 0x001FBB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IsReady)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D8A8 RID: 55464 RVA: 0x001FD94C File Offset: 0x001FBB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangeReadyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IsReady)
			{
				this.IsReady = other.IsReady;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D8A9 RID: 55465 RVA: 0x001FD99C File Offset: 0x001FBB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8AA RID: 55466 RVA: 0x001FD9A8 File Offset: 0x001FBBA8
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsReady = input.ReadBool();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005A8E RID: 23182
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A8F RID: 23183
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04005A90 RID: 23184
		private int playerId_;

		// Token: 0x04005A91 RID: 23185
		public const int IsReadyFieldNumber = 15;

		// Token: 0x04005A92 RID: 23186
		private bool isReady_;
	}
}
