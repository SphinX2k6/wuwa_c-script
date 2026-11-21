using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000641 RID: 1601
	public sealed class FriendInfo : IMessage<FriendInfo>, IMessage, IEquatable<FriendInfo>, IDeepCloneable<FriendInfo>, IBufferMessage
	{
		// Token: 0x0600939E RID: 37790 RVA: 0x001650DC File Offset: 0x001632DC
		[NullableContext(1)]
		public static FriendInfo Create()
		{
			return new FriendInfo();
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x0600939F RID: 37791 RVA: 0x001650E3 File Offset: 0x001632E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendInfo> Parser
		{
			get
			{
				return FriendInfo._parser;
			}
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x060093A0 RID: 37792 RVA: 0x001650EA File Offset: 0x001632EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x060093A1 RID: 37793 RVA: 0x001650ED File Offset: 0x001632ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendInfo.Descriptor;
			}
		}

		// Token: 0x060093A2 RID: 37794 RVA: 0x001650F4 File Offset: 0x001632F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendInfo()
		{
		}

		// Token: 0x060093A3 RID: 37795 RVA: 0x00165108 File Offset: 0x00163308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendInfo(FriendInfo other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.remark_ = other.remark_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093A4 RID: 37796 RVA: 0x00165154 File Offset: 0x00163354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendInfo Clone()
		{
			return new FriendInfo(this);
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x060093A5 RID: 37797 RVA: 0x0016515C File Offset: 0x0016335C
		// (set) Token: 0x060093A6 RID: 37798 RVA: 0x00165164 File Offset: 0x00163364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x060093A7 RID: 37799 RVA: 0x0016516D File Offset: 0x0016336D
		// (set) Token: 0x060093A8 RID: 37800 RVA: 0x00165175 File Offset: 0x00163375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Remark
		{
			get
			{
				return this.remark_;
			}
			set
			{
				this.remark_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060093A9 RID: 37801 RVA: 0x00165188 File Offset: 0x00163388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendInfo);
		}

		// Token: 0x060093AA RID: 37802 RVA: 0x00165198 File Offset: 0x00163398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && !(this.Remark != other.Remark) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060093AB RID: 37803 RVA: 0x001651EC File Offset: 0x001633EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.Remark.Length != 0)
			{
				num ^= this.Remark.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060093AC RID: 37804 RVA: 0x00165243 File Offset: 0x00163443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060093AD RID: 37805 RVA: 0x00165250 File Offset: 0x00163450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093AE RID: 37806 RVA: 0x0016525C File Offset: 0x0016345C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Info);
			}
			if (this.Remark.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Remark);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093AF RID: 37807 RVA: 0x001652BC File Offset: 0x001634BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.Remark.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Remark);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060093B0 RID: 37808 RVA: 0x00165318 File Offset: 0x00163518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new PlayerDetails();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.Remark.Length != 0)
			{
				this.Remark = other.Remark;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060093B1 RID: 37809 RVA: 0x00165385 File Offset: 0x00163585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093B2 RID: 37810 RVA: 0x00165390 File Offset: 0x00163590
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Remark = input.ReadString();
					}
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new PlayerDetails();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x0400473B RID: 18235
		private static readonly MessageParser<FriendInfo> _parser = new MessageParser<FriendInfo>(() => new FriendInfo());

		// Token: 0x0400473C RID: 18236
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400473D RID: 18237
		public const int InfoFieldNumber = 1;

		// Token: 0x0400473E RID: 18238
		private PlayerDetails info_;

		// Token: 0x0400473F RID: 18239
		public const int RemarkFieldNumber = 2;

		// Token: 0x04004740 RID: 18240
		private string remark_ = "";
	}
}
