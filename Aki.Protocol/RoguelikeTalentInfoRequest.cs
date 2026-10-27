using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FBE RID: 4030
	[NetMessage(EMessageId.RoguelikeTalentInfoRequest)]
	public sealed class RoguelikeTalentInfoRequest : IMessage<RoguelikeTalentInfoRequest>, IMessage, IEquatable<RoguelikeTalentInfoRequest>, IDeepCloneable<RoguelikeTalentInfoRequest>, IBufferMessage
	{
		// Token: 0x060158C6 RID: 88262 RVA: 0x00320E00 File Offset: 0x0031F000
		[NullableContext(1)]
		public static RoguelikeTalentInfoRequest Create()
		{
			return new RoguelikeTalentInfoRequest();
		}

		// Token: 0x170047DC RID: 18396
		// (get) Token: 0x060158C7 RID: 88263 RVA: 0x00320E07 File Offset: 0x0031F007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047DD RID: 18397
		// (get) Token: 0x060158C8 RID: 88264 RVA: 0x00320E0A File Offset: 0x0031F00A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTalentInfoRequest.Descriptor;
			}
		}

		// Token: 0x060158C9 RID: 88265 RVA: 0x00320E11 File Offset: 0x0031F011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentInfoRequest()
		{
		}

		// Token: 0x060158CA RID: 88266 RVA: 0x00320E19 File Offset: 0x0031F019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentInfoRequest(RoguelikeTalentInfoRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060158CB RID: 88267 RVA: 0x00320E3E File Offset: 0x0031F03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentInfoRequest Clone()
		{
			return new RoguelikeTalentInfoRequest(this);
		}

		// Token: 0x170047DE RID: 18398
		// (get) Token: 0x060158CC RID: 88268 RVA: 0x00320E46 File Offset: 0x0031F046
		// (set) Token: 0x060158CD RID: 88269 RVA: 0x00320E4E File Offset: 0x0031F04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x060158CE RID: 88270 RVA: 0x00320E57 File Offset: 0x0031F057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTalentInfoRequest);
		}

		// Token: 0x060158CF RID: 88271 RVA: 0x00320E65 File Offset: 0x0031F065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTalentInfoRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060158D0 RID: 88272 RVA: 0x00320E94 File Offset: 0x0031F094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060158D1 RID: 88273 RVA: 0x00320ED3 File Offset: 0x0031F0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060158D2 RID: 88274 RVA: 0x00320EE0 File Offset: 0x0031F0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060158D3 RID: 88275 RVA: 0x00320EE9 File Offset: 0x0031F0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060158D4 RID: 88276 RVA: 0x00320F1C File Offset: 0x0031F11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060158D5 RID: 88277 RVA: 0x00320F5A File Offset: 0x0031F15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeTalentInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060158D6 RID: 88278 RVA: 0x00320F8B File Offset: 0x0031F18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060158D7 RID: 88279 RVA: 0x00320F94 File Offset: 0x0031F194
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SeasonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008183 RID: 33155
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008184 RID: 33156
		public const int SeasonIdFieldNumber = 7;

		// Token: 0x04008185 RID: 33157
		private int seasonId_;
	}
}
