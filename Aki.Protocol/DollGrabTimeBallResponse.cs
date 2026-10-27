using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003FA RID: 1018
	[NetMessage(EMessageId.DollGrabTimeBallResponse)]
	public sealed class DollGrabTimeBallResponse : IMessage<DollGrabTimeBallResponse>, IMessage, IEquatable<DollGrabTimeBallResponse>, IDeepCloneable<DollGrabTimeBallResponse>, IBufferMessage
	{
		// Token: 0x0600626F RID: 25199 RVA: 0x000ED0F0 File Offset: 0x000EB2F0
		[NullableContext(1)]
		public static DollGrabTimeBallResponse Create()
		{
			return new DollGrabTimeBallResponse();
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x06006270 RID: 25200 RVA: 0x000ED0F7 File Offset: 0x000EB2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06006271 RID: 25201 RVA: 0x000ED0FA File Offset: 0x000EB2FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabTimeBallResponse.Descriptor;
			}
		}

		// Token: 0x06006272 RID: 25202 RVA: 0x000ED101 File Offset: 0x000EB301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabTimeBallResponse()
		{
		}

		// Token: 0x06006273 RID: 25203 RVA: 0x000ED114 File Offset: 0x000EB314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabTimeBallResponse(DollGrabTimeBallResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.grabItemInfos_ = other.grabItemInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006274 RID: 25204 RVA: 0x000ED14A File Offset: 0x000EB34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabTimeBallResponse Clone()
		{
			return new DollGrabTimeBallResponse(this);
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06006275 RID: 25205 RVA: 0x000ED152 File Offset: 0x000EB352
		// (set) Token: 0x06006276 RID: 25206 RVA: 0x000ED15A File Offset: 0x000EB35A
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

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06006277 RID: 25207 RVA: 0x000ED163 File Offset: 0x000EB363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DollGrabItemInfo> GrabItemInfos
		{
			get
			{
				return this.grabItemInfos_;
			}
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x000ED16B File Offset: 0x000EB36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabTimeBallResponse);
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x000ED17C File Offset: 0x000EB37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabTimeBallResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.grabItemInfos_.Equals(other.grabItemInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x000ED1CC File Offset: 0x000EB3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.grabItemInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x000ED21F File Offset: 0x000EB41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x000ED22C File Offset: 0x000EB42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600627D RID: 25213 RVA: 0x000ED238 File Offset: 0x000EB438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.grabItemInfos_.WriteTo(ref output, DollGrabTimeBallResponse._repeated_grabItemInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x000ED288 File Offset: 0x000EB488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.grabItemInfos_.CalculateSize(DollGrabTimeBallResponse._repeated_grabItemInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600627F RID: 25215 RVA: 0x000ED2DC File Offset: 0x000EB4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabTimeBallResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.grabItemInfos_.Add(other.grabItemInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006280 RID: 25216 RVA: 0x000ED329 File Offset: 0x000EB529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006281 RID: 25217 RVA: 0x000ED334 File Offset: 0x000EB534
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
				if (num != 32U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.grabItemInfos_.AddEntriesFrom(ref input, DollGrabTimeBallResponse._repeated_grabItemInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040037DA RID: 14298
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037DB RID: 14299
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040037DC RID: 14300
		private ErrorCode errorCode_;

		// Token: 0x040037DD RID: 14301
		public const int GrabItemInfosFieldNumber = 14;

		// Token: 0x040037DE RID: 14302
		private static readonly FieldCodec<DollGrabItemInfo> _repeated_grabItemInfos_codec = FieldCodec.ForMessage<DollGrabItemInfo>(114U, DollGrabItemInfo.Parser);

		// Token: 0x040037DF RID: 14303
		private readonly RepeatedField<DollGrabItemInfo> grabItemInfos_ = new RepeatedField<DollGrabItemInfo>();
	}
}
