using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200149A RID: 5274
	[NetMessage(EMessageId.UpdateInstanceOwnerInfoNotify)]
	public sealed class UpdateInstanceOwnerInfoNotify : IMessage<UpdateInstanceOwnerInfoNotify>, IMessage, IEquatable<UpdateInstanceOwnerInfoNotify>, IDeepCloneable<UpdateInstanceOwnerInfoNotify>, IBufferMessage
	{
		// Token: 0x0601BE5B RID: 114267 RVA: 0x004085CE File Offset: 0x004067CE
		[NullableContext(1)]
		public static UpdateInstanceOwnerInfoNotify Create()
		{
			return new UpdateInstanceOwnerInfoNotify();
		}

		// Token: 0x17005E05 RID: 24069
		// (get) Token: 0x0601BE5C RID: 114268 RVA: 0x004085D5 File Offset: 0x004067D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E06 RID: 24070
		// (get) Token: 0x0601BE5D RID: 114269 RVA: 0x004085D8 File Offset: 0x004067D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateInstanceOwnerInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601BE5E RID: 114270 RVA: 0x004085DF File Offset: 0x004067DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateInstanceOwnerInfoNotify()
		{
		}

		// Token: 0x0601BE5F RID: 114271 RVA: 0x004085E8 File Offset: 0x004067E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateInstanceOwnerInfoNotify(UpdateInstanceOwnerInfoNotify other) : this()
		{
			this.id_ = other.id_;
			this.instanceOwnerInfo_ = ((other.instanceOwnerInfo_ != null) ? other.instanceOwnerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE60 RID: 114272 RVA: 0x00408634 File Offset: 0x00406834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateInstanceOwnerInfoNotify Clone()
		{
			return new UpdateInstanceOwnerInfoNotify(this);
		}

		// Token: 0x17005E07 RID: 24071
		// (get) Token: 0x0601BE61 RID: 114273 RVA: 0x0040863C File Offset: 0x0040683C
		// (set) Token: 0x0601BE62 RID: 114274 RVA: 0x00408644 File Offset: 0x00406844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x17005E08 RID: 24072
		// (get) Token: 0x0601BE63 RID: 114275 RVA: 0x0040864D File Offset: 0x0040684D
		// (set) Token: 0x0601BE64 RID: 114276 RVA: 0x00408655 File Offset: 0x00406855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceOwnerInfo InstanceOwnerInfo
		{
			get
			{
				return this.instanceOwnerInfo_;
			}
			set
			{
				this.instanceOwnerInfo_ = value;
			}
		}

		// Token: 0x0601BE65 RID: 114277 RVA: 0x0040865E File Offset: 0x0040685E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateInstanceOwnerInfoNotify);
		}

		// Token: 0x0601BE66 RID: 114278 RVA: 0x0040866C File Offset: 0x0040686C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateInstanceOwnerInfoNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this.InstanceOwnerInfo, other.InstanceOwnerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE67 RID: 114279 RVA: 0x004086BC File Offset: 0x004068BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.instanceOwnerInfo_ != null)
			{
				num ^= this.InstanceOwnerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BE68 RID: 114280 RVA: 0x00408711 File Offset: 0x00406911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE69 RID: 114281 RVA: 0x0040871E File Offset: 0x0040691E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE6A RID: 114282 RVA: 0x00408728 File Offset: 0x00406928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.instanceOwnerInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.InstanceOwnerInfo);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BE6B RID: 114283 RVA: 0x00408784 File Offset: 0x00406984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.instanceOwnerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InstanceOwnerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BE6C RID: 114284 RVA: 0x004087DC File Offset: 0x004069DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateInstanceOwnerInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.instanceOwnerInfo_ != null)
			{
				if (this.instanceOwnerInfo_ == null)
				{
					this.InstanceOwnerInfo = new InstanceOwnerInfo();
				}
				this.InstanceOwnerInfo.MergeFrom(other.InstanceOwnerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BE6D RID: 114285 RVA: 0x00408844 File Offset: 0x00406A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE6E RID: 114286 RVA: 0x00408850 File Offset: 0x00406A50
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
				if (num != 90U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					if (this.instanceOwnerInfo_ == null)
					{
						this.InstanceOwnerInfo = new InstanceOwnerInfo();
					}
					input.ReadMessage(this.InstanceOwnerInfo);
				}
			}
		}

		// Token: 0x0400A05A RID: 41050
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A05B RID: 41051
		public const int IdFieldNumber = 15;

		// Token: 0x0400A05C RID: 41052
		private long id_;

		// Token: 0x0400A05D RID: 41053
		public const int InstanceOwnerInfoFieldNumber = 11;

		// Token: 0x0400A05E RID: 41054
		private InstanceOwnerInfo instanceOwnerInfo_;
	}
}
