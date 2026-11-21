using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F80 RID: 3968
	[NetMessage(EMessageId.RoguelikeBossInstStartRequest)]
	public sealed class RoguelikeBossInstStartRequest : IMessage<RoguelikeBossInstStartRequest>, IMessage, IEquatable<RoguelikeBossInstStartRequest>, IDeepCloneable<RoguelikeBossInstStartRequest>, IBufferMessage
	{
		// Token: 0x06015403 RID: 87043 RVA: 0x00316025 File Offset: 0x00314225
		[NullableContext(1)]
		public static RoguelikeBossInstStartRequest Create()
		{
			return new RoguelikeBossInstStartRequest();
		}

		// Token: 0x170046D2 RID: 18130
		// (get) Token: 0x06015404 RID: 87044 RVA: 0x0031602C File Offset: 0x0031422C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046D3 RID: 18131
		// (get) Token: 0x06015405 RID: 87045 RVA: 0x0031602F File Offset: 0x0031422F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeBossInstStartRequest.Descriptor;
			}
		}

		// Token: 0x06015406 RID: 87046 RVA: 0x00316036 File Offset: 0x00314236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeBossInstStartRequest()
		{
		}

		// Token: 0x06015407 RID: 87047 RVA: 0x00316049 File Offset: 0x00314249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeBossInstStartRequest(RoguelikeBossInstStartRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015408 RID: 87048 RVA: 0x0031607F File Offset: 0x0031427F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeBossInstStartRequest Clone()
		{
			return new RoguelikeBossInstStartRequest(this);
		}

		// Token: 0x170046D4 RID: 18132
		// (get) Token: 0x06015409 RID: 87049 RVA: 0x00316087 File Offset: 0x00314287
		// (set) Token: 0x0601540A RID: 87050 RVA: 0x0031608F File Offset: 0x0031428F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170046D5 RID: 18133
		// (get) Token: 0x0601540B RID: 87051 RVA: 0x00316098 File Offset: 0x00314298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x0601540C RID: 87052 RVA: 0x003160A0 File Offset: 0x003142A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeBossInstStartRequest);
		}

		// Token: 0x0601540D RID: 87053 RVA: 0x003160B0 File Offset: 0x003142B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeBossInstStartRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601540E RID: 87054 RVA: 0x00316100 File Offset: 0x00314300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.roleList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601540F RID: 87055 RVA: 0x0031614D File Offset: 0x0031434D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015410 RID: 87056 RVA: 0x0031615A File Offset: 0x0031435A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015411 RID: 87057 RVA: 0x00316164 File Offset: 0x00314364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			this.roleList_.WriteTo(ref output, RoguelikeBossInstStartRequest._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015412 RID: 87058 RVA: 0x003161B4 File Offset: 0x003143B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.roleList_.CalculateSize(RoguelikeBossInstStartRequest._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015413 RID: 87059 RVA: 0x00316208 File Offset: 0x00314408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeBossInstStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.roleList_.Add(other.roleList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015414 RID: 87060 RVA: 0x00316255 File Offset: 0x00314455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015415 RID: 87061 RVA: 0x00316260 File Offset: 0x00314460
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
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleList_.AddEntriesFrom(ref input, RoguelikeBossInstStartRequest._repeated_roleList_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400805B RID: 32859
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400805C RID: 32860
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x0400805D RID: 32861
		private int activityId_;

		// Token: 0x0400805E RID: 32862
		public const int RoleListFieldNumber = 15;

		// Token: 0x0400805F RID: 32863
		private static readonly FieldCodec<int> _repeated_roleList_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04008060 RID: 32864
		private readonly RepeatedField<int> roleList_ = new RepeatedField<int>();
	}
}
