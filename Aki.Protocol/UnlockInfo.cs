using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001489 RID: 5257
	public sealed class UnlockInfo : IMessage<UnlockInfo>, IMessage, IEquatable<UnlockInfo>, IDeepCloneable<UnlockInfo>, IBufferMessage
	{
		// Token: 0x0601BD15 RID: 113941 RVA: 0x00405FE2 File Offset: 0x004041E2
		[NullableContext(1)]
		public static UnlockInfo Create()
		{
			return new UnlockInfo();
		}

		// Token: 0x17005DC8 RID: 24008
		// (get) Token: 0x0601BD16 RID: 113942 RVA: 0x00405FE9 File Offset: 0x004041E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockInfo> Parser
		{
			get
			{
				return UnlockInfo._parser;
			}
		}

		// Token: 0x17005DC9 RID: 24009
		// (get) Token: 0x0601BD17 RID: 113943 RVA: 0x00405FF0 File Offset: 0x004041F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DCA RID: 24010
		// (get) Token: 0x0601BD18 RID: 113944 RVA: 0x00405FF3 File Offset: 0x004041F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockInfo.Descriptor;
			}
		}

		// Token: 0x0601BD19 RID: 113945 RVA: 0x00405FFA File Offset: 0x004041FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInfo()
		{
		}

		// Token: 0x0601BD1A RID: 113946 RVA: 0x00406002 File Offset: 0x00404202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInfo(UnlockInfo other) : this()
		{
			this.shopId_ = other.shopId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD1B RID: 113947 RVA: 0x00406033 File Offset: 0x00404233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInfo Clone()
		{
			return new UnlockInfo(this);
		}

		// Token: 0x17005DCB RID: 24011
		// (get) Token: 0x0601BD1C RID: 113948 RVA: 0x0040603B File Offset: 0x0040423B
		// (set) Token: 0x0601BD1D RID: 113949 RVA: 0x00406043 File Offset: 0x00404243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x17005DCC RID: 24012
		// (get) Token: 0x0601BD1E RID: 113950 RVA: 0x0040604C File Offset: 0x0040424C
		// (set) Token: 0x0601BD1F RID: 113951 RVA: 0x00406054 File Offset: 0x00404254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0601BD20 RID: 113952 RVA: 0x0040605D File Offset: 0x0040425D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockInfo);
		}

		// Token: 0x0601BD21 RID: 113953 RVA: 0x0040606B File Offset: 0x0040426B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockInfo other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD22 RID: 113954 RVA: 0x004060AC File Offset: 0x004042AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BD23 RID: 113955 RVA: 0x00406104 File Offset: 0x00404304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD24 RID: 113956 RVA: 0x00406111 File Offset: 0x00404311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD25 RID: 113957 RVA: 0x0040611C File Offset: 0x0040431C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShopId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BD26 RID: 113958 RVA: 0x00406174 File Offset: 0x00404374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BD27 RID: 113959 RVA: 0x004061CC File Offset: 0x004043CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BD28 RID: 113960 RVA: 0x0040621C File Offset: 0x0040441C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD29 RID: 113961 RVA: 0x00406228 File Offset: 0x00404428
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.ShopId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A00D RID: 40973
		private static readonly MessageParser<UnlockInfo> _parser = new MessageParser<UnlockInfo>(() => new UnlockInfo());

		// Token: 0x0400A00E RID: 40974
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A00F RID: 40975
		public const int ShopIdFieldNumber = 1;

		// Token: 0x0400A010 RID: 40976
		private int shopId_;

		// Token: 0x0400A011 RID: 40977
		public const int IdFieldNumber = 2;

		// Token: 0x0400A012 RID: 40978
		private int id_;
	}
}
