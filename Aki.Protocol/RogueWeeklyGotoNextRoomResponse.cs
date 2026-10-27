using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001039 RID: 4153
	[NetMessage(EMessageId.RogueWeeklyGotoNextRoomResponse)]
	public sealed class RogueWeeklyGotoNextRoomResponse : IMessage<RogueWeeklyGotoNextRoomResponse>, IMessage, IEquatable<RogueWeeklyGotoNextRoomResponse>, IDeepCloneable<RogueWeeklyGotoNextRoomResponse>, IBufferMessage
	{
		// Token: 0x06016321 RID: 90913 RVA: 0x003398B4 File Offset: 0x00337AB4
		[NullableContext(1)]
		public static RogueWeeklyGotoNextRoomResponse Create()
		{
			return new RogueWeeklyGotoNextRoomResponse();
		}

		// Token: 0x17004A34 RID: 18996
		// (get) Token: 0x06016322 RID: 90914 RVA: 0x003398BB File Offset: 0x00337ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A35 RID: 18997
		// (get) Token: 0x06016323 RID: 90915 RVA: 0x003398BE File Offset: 0x00337ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyGotoNextRoomResponse.Descriptor;
			}
		}

		// Token: 0x06016324 RID: 90916 RVA: 0x003398C5 File Offset: 0x00337AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGotoNextRoomResponse()
		{
		}

		// Token: 0x06016325 RID: 90917 RVA: 0x003398CD File Offset: 0x00337ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGotoNextRoomResponse(RogueWeeklyGotoNextRoomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016326 RID: 90918 RVA: 0x003398F2 File Offset: 0x00337AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyGotoNextRoomResponse Clone()
		{
			return new RogueWeeklyGotoNextRoomResponse(this);
		}

		// Token: 0x17004A36 RID: 18998
		// (get) Token: 0x06016327 RID: 90919 RVA: 0x003398FA File Offset: 0x00337AFA
		// (set) Token: 0x06016328 RID: 90920 RVA: 0x00339902 File Offset: 0x00337B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06016329 RID: 90921 RVA: 0x0033990B File Offset: 0x00337B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyGotoNextRoomResponse);
		}

		// Token: 0x0601632A RID: 90922 RVA: 0x00339919 File Offset: 0x00337B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyGotoNextRoomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601632B RID: 90923 RVA: 0x00339948 File Offset: 0x00337B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601632C RID: 90924 RVA: 0x0033998D File Offset: 0x00337B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601632D RID: 90925 RVA: 0x0033999A File Offset: 0x00337B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601632E RID: 90926 RVA: 0x003399A3 File Offset: 0x00337BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601632F RID: 90927 RVA: 0x003399D8 File Offset: 0x00337BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016330 RID: 90928 RVA: 0x00339A16 File Offset: 0x00337C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyGotoNextRoomResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016331 RID: 90929 RVA: 0x00339A47 File Offset: 0x00337C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016332 RID: 90930 RVA: 0x00339A50 File Offset: 0x00337C50
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040084D9 RID: 34009
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084DA RID: 34010
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040084DB RID: 34011
		private ErrorCode errorCode_;
	}
}
