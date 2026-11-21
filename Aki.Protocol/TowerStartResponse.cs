using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001442 RID: 5186
	[NetMessage(EMessageId.TowerStartResponse)]
	public sealed class TowerStartResponse : IMessage<TowerStartResponse>, IMessage, IEquatable<TowerStartResponse>, IDeepCloneable<TowerStartResponse>, IBufferMessage
	{
		// Token: 0x0601B8DC RID: 112860 RVA: 0x00401350 File Offset: 0x003FF550
		[NullableContext(1)]
		public static TowerStartResponse Create()
		{
			return new TowerStartResponse();
		}

		// Token: 0x17005D48 RID: 23880
		// (get) Token: 0x0601B8DD RID: 112861 RVA: 0x00401357 File Offset: 0x003FF557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D49 RID: 23881
		// (get) Token: 0x0601B8DE RID: 112862 RVA: 0x0040135A File Offset: 0x003FF55A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerStartResponse.Descriptor;
			}
		}

		// Token: 0x0601B8DF RID: 112863 RVA: 0x00401361 File Offset: 0x003FF561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerStartResponse()
		{
		}

		// Token: 0x0601B8E0 RID: 112864 RVA: 0x00401369 File Offset: 0x003FF569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerStartResponse(TowerStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.needUpdateSeason_ = other.needUpdateSeason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B8E1 RID: 112865 RVA: 0x0040139A File Offset: 0x003FF59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerStartResponse Clone()
		{
			return new TowerStartResponse(this);
		}

		// Token: 0x17005D4A RID: 23882
		// (get) Token: 0x0601B8E2 RID: 112866 RVA: 0x004013A2 File Offset: 0x003FF5A2
		// (set) Token: 0x0601B8E3 RID: 112867 RVA: 0x004013AA File Offset: 0x003FF5AA
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

		// Token: 0x17005D4B RID: 23883
		// (get) Token: 0x0601B8E4 RID: 112868 RVA: 0x004013B3 File Offset: 0x003FF5B3
		// (set) Token: 0x0601B8E5 RID: 112869 RVA: 0x004013BB File Offset: 0x003FF5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedUpdateSeason
		{
			get
			{
				return this.needUpdateSeason_;
			}
			set
			{
				this.needUpdateSeason_ = value;
			}
		}

		// Token: 0x0601B8E6 RID: 112870 RVA: 0x004013C4 File Offset: 0x003FF5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerStartResponse);
		}

		// Token: 0x0601B8E7 RID: 112871 RVA: 0x004013D2 File Offset: 0x003FF5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.NeedUpdateSeason == other.NeedUpdateSeason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B8E8 RID: 112872 RVA: 0x00401410 File Offset: 0x003FF610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.NeedUpdateSeason)
			{
				num ^= this.NeedUpdateSeason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B8E9 RID: 112873 RVA: 0x0040146E File Offset: 0x003FF66E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B8EA RID: 112874 RVA: 0x0040147B File Offset: 0x003FF67B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B8EB RID: 112875 RVA: 0x00401484 File Offset: 0x003FF684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.NeedUpdateSeason)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.NeedUpdateSeason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B8EC RID: 112876 RVA: 0x004014E0 File Offset: 0x003FF6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.NeedUpdateSeason)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B8ED RID: 112877 RVA: 0x0040152C File Offset: 0x003FF72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerStartResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.NeedUpdateSeason)
			{
				this.NeedUpdateSeason = other.NeedUpdateSeason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B8EE RID: 112878 RVA: 0x0040157C File Offset: 0x003FF77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B8EF RID: 112879 RVA: 0x00401588 File Offset: 0x003FF788
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
				if (num != 48U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NeedUpdateSeason = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A045 RID: 41029
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A046 RID: 41030
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400A047 RID: 41031
		private ErrorCode errorCode_;

		// Token: 0x0400A048 RID: 41032
		public const int NeedUpdateSeasonFieldNumber = 12;

		// Token: 0x0400A049 RID: 41033
		private bool needUpdateSeason_;
	}
}
