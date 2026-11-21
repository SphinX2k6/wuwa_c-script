using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A1 RID: 5025
	[NetMessage(EMessageId.TeamRecommendResponse)]
	public sealed class TeamRecommendResponse : IMessage<TeamRecommendResponse>, IMessage, IEquatable<TeamRecommendResponse>, IDeepCloneable<TeamRecommendResponse>, IBufferMessage
	{
		// Token: 0x0601ABEE RID: 109550 RVA: 0x003E52E2 File Offset: 0x003E34E2
		[NullableContext(1)]
		public static TeamRecommendResponse Create()
		{
			return new TeamRecommendResponse();
		}

		// Token: 0x17005A8D RID: 23181
		// (get) Token: 0x0601ABEF RID: 109551 RVA: 0x003E52E9 File Offset: 0x003E34E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A8E RID: 23182
		// (get) Token: 0x0601ABF0 RID: 109552 RVA: 0x003E52EC File Offset: 0x003E34EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamRecommendResponse.Descriptor;
			}
		}

		// Token: 0x0601ABF1 RID: 109553 RVA: 0x003E52F3 File Offset: 0x003E34F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendResponse()
		{
		}

		// Token: 0x0601ABF2 RID: 109554 RVA: 0x003E5306 File Offset: 0x003E3506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendResponse(TeamRecommendResponse other) : this()
		{
			this.teamRecommendList_ = other.teamRecommendList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ABF3 RID: 109555 RVA: 0x003E5330 File Offset: 0x003E3530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendResponse Clone()
		{
			return new TeamRecommendResponse(this);
		}

		// Token: 0x17005A8F RID: 23183
		// (get) Token: 0x0601ABF4 RID: 109556 RVA: 0x003E5338 File Offset: 0x003E3538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TeamRecommendRole> TeamRecommendList
		{
			get
			{
				return this.teamRecommendList_;
			}
		}

		// Token: 0x0601ABF5 RID: 109557 RVA: 0x003E5340 File Offset: 0x003E3540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamRecommendResponse);
		}

		// Token: 0x0601ABF6 RID: 109558 RVA: 0x003E534E File Offset: 0x003E354E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamRecommendResponse other)
		{
			return other != null && (other == this || (this.teamRecommendList_.Equals(other.teamRecommendList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ABF7 RID: 109559 RVA: 0x003E5384 File Offset: 0x003E3584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.teamRecommendList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ABF8 RID: 109560 RVA: 0x003E53B8 File Offset: 0x003E35B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ABF9 RID: 109561 RVA: 0x003E53C5 File Offset: 0x003E35C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ABFA RID: 109562 RVA: 0x003E53CE File Offset: 0x003E35CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.teamRecommendList_.WriteTo(ref output, TeamRecommendResponse._repeated_teamRecommendList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ABFB RID: 109563 RVA: 0x003E53F8 File Offset: 0x003E35F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.teamRecommendList_.CalculateSize(TeamRecommendResponse._repeated_teamRecommendList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ABFC RID: 109564 RVA: 0x003E5431 File Offset: 0x003E3631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamRecommendResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.teamRecommendList_.Add(other.teamRecommendList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ABFD RID: 109565 RVA: 0x003E545F File Offset: 0x003E365F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ABFE RID: 109566 RVA: 0x003E5468 File Offset: 0x003E3668
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.teamRecommendList_.AddEntriesFrom(ref input, TeamRecommendResponse._repeated_teamRecommendList_codec);
				}
			}
		}

		// Token: 0x04009C8D RID: 40077
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C8E RID: 40078
		public const int TeamRecommendListFieldNumber = 8;

		// Token: 0x04009C8F RID: 40079
		private static readonly FieldCodec<TeamRecommendRole> _repeated_teamRecommendList_codec = FieldCodec.ForMessage<TeamRecommendRole>(66U, TeamRecommendRole.Parser);

		// Token: 0x04009C90 RID: 40080
		private readonly RepeatedField<TeamRecommendRole> teamRecommendList_ = new RepeatedField<TeamRecommendRole>();
	}
}
