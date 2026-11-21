using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DDE RID: 3550
	[NetMessage(EMessageId.PsnSettingResponse)]
	public sealed class PsnSettingResponse : IMessage<PsnSettingResponse>, IMessage, IEquatable<PsnSettingResponse>, IDeepCloneable<PsnSettingResponse>, IBufferMessage
	{
		// Token: 0x06013202 RID: 78338 RVA: 0x002C9B62 File Offset: 0x002C7D62
		[NullableContext(1)]
		public static PsnSettingResponse Create()
		{
			return new PsnSettingResponse();
		}

		// Token: 0x17003F78 RID: 16248
		// (get) Token: 0x06013203 RID: 78339 RVA: 0x002C9B69 File Offset: 0x002C7D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F79 RID: 16249
		// (get) Token: 0x06013204 RID: 78340 RVA: 0x002C9B6C File Offset: 0x002C7D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PsnSettingResponse.Descriptor;
			}
		}

		// Token: 0x06013205 RID: 78341 RVA: 0x002C9B73 File Offset: 0x002C7D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingResponse()
		{
		}

		// Token: 0x06013206 RID: 78342 RVA: 0x002C9B7B File Offset: 0x002C7D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingResponse(PsnSettingResponse other) : this()
		{
			this.matchPsnUser_ = other.matchPsnUser_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013207 RID: 78343 RVA: 0x002C9BA0 File Offset: 0x002C7DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingResponse Clone()
		{
			return new PsnSettingResponse(this);
		}

		// Token: 0x17003F7A RID: 16250
		// (get) Token: 0x06013208 RID: 78344 RVA: 0x002C9BA8 File Offset: 0x002C7DA8
		// (set) Token: 0x06013209 RID: 78345 RVA: 0x002C9BB0 File Offset: 0x002C7DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MatchPsnUser
		{
			get
			{
				return this.matchPsnUser_;
			}
			set
			{
				this.matchPsnUser_ = value;
			}
		}

		// Token: 0x0601320A RID: 78346 RVA: 0x002C9BB9 File Offset: 0x002C7DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PsnSettingResponse);
		}

		// Token: 0x0601320B RID: 78347 RVA: 0x002C9BC7 File Offset: 0x002C7DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PsnSettingResponse other)
		{
			return other != null && (other == this || (this.MatchPsnUser == other.MatchPsnUser && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601320C RID: 78348 RVA: 0x002C9BF8 File Offset: 0x002C7DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MatchPsnUser)
			{
				num ^= this.MatchPsnUser.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601320D RID: 78349 RVA: 0x002C9C37 File Offset: 0x002C7E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601320E RID: 78350 RVA: 0x002C9C44 File Offset: 0x002C7E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601320F RID: 78351 RVA: 0x002C9C4D File Offset: 0x002C7E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchPsnUser)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.MatchPsnUser);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013210 RID: 78352 RVA: 0x002C9C80 File Offset: 0x002C7E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MatchPsnUser)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013211 RID: 78353 RVA: 0x002C9CB2 File Offset: 0x002C7EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PsnSettingResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MatchPsnUser)
			{
				this.MatchPsnUser = other.MatchPsnUser;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013212 RID: 78354 RVA: 0x002C9CE3 File Offset: 0x002C7EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013213 RID: 78355 RVA: 0x002C9CEC File Offset: 0x002C7EEC
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MatchPsnUser = input.ReadBool();
				}
			}
		}

		// Token: 0x04007645 RID: 30277
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007646 RID: 30278
		public const int MatchPsnUserFieldNumber = 5;

		// Token: 0x04007647 RID: 30279
		private bool matchPsnUser_;
	}
}
