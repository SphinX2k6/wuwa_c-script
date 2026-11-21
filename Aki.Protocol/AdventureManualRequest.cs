using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C0 RID: 192
	[NetMessage(EMessageId.AdventureManualRequest)]
	public sealed class AdventureManualRequest : IMessage<AdventureManualRequest>, IMessage, IEquatable<AdventureManualRequest>, IDeepCloneable<AdventureManualRequest>, IBufferMessage
	{
		// Token: 0x06001EF3 RID: 7923 RVA: 0x000545CF File Offset: 0x000527CF
		[NullableContext(1)]
		public static AdventureManualRequest Create()
		{
			return new AdventureManualRequest();
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x000545D6 File Offset: 0x000527D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x000545D9 File Offset: 0x000527D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureManualRequest.Descriptor;
			}
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x000545E0 File Offset: 0x000527E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualRequest()
		{
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x000545E8 File Offset: 0x000527E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualRequest(AdventureManualRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0005460D File Offset: 0x0005280D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualRequest Clone()
		{
			return new AdventureManualRequest(this);
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x00054615 File Offset: 0x00052815
		// (set) Token: 0x06001EFA RID: 7930 RVA: 0x0005461D File Offset: 0x0005281D
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

		// Token: 0x06001EFB RID: 7931 RVA: 0x00054626 File Offset: 0x00052826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureManualRequest);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00054634 File Offset: 0x00052834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureManualRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00054664 File Offset: 0x00052864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x000546A3 File Offset: 0x000528A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x000546B0 File Offset: 0x000528B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x000546B9 File Offset: 0x000528B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x000546EC File Offset: 0x000528EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x0005472A File Offset: 0x0005292A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureManualRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x0005475B File Offset: 0x0005295B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00054764 File Offset: 0x00052964
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
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040023D5 RID: 9173
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023D6 RID: 9174
		public const int PlayerIdFieldNumber = 7;

		// Token: 0x040023D7 RID: 9175
		private int playerId_;
	}
}
