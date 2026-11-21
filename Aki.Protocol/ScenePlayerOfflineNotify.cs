using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011BF RID: 4543
	[NetMessage(EMessageId.ScenePlayerOfflineNotify)]
	public sealed class ScenePlayerOfflineNotify : IMessage<ScenePlayerOfflineNotify>, IMessage, IEquatable<ScenePlayerOfflineNotify>, IDeepCloneable<ScenePlayerOfflineNotify>, IBufferMessage
	{
		// Token: 0x0601841F RID: 99359 RVA: 0x00388107 File Offset: 0x00386307
		[NullableContext(1)]
		public static ScenePlayerOfflineNotify Create()
		{
			return new ScenePlayerOfflineNotify();
		}

		// Token: 0x170051BC RID: 20924
		// (get) Token: 0x06018420 RID: 99360 RVA: 0x0038810E File Offset: 0x0038630E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051BD RID: 20925
		// (get) Token: 0x06018421 RID: 99361 RVA: 0x00388111 File Offset: 0x00386311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScenePlayerOfflineNotify.Descriptor;
			}
		}

		// Token: 0x06018422 RID: 99362 RVA: 0x00388118 File Offset: 0x00386318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlayerOfflineNotify()
		{
		}

		// Token: 0x06018423 RID: 99363 RVA: 0x00388120 File Offset: 0x00386320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlayerOfflineNotify(ScenePlayerOfflineNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.isOffline_ = other.isOffline_;
			this.isReLogin_ = other.isReLogin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018424 RID: 99364 RVA: 0x0038815D File Offset: 0x0038635D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlayerOfflineNotify Clone()
		{
			return new ScenePlayerOfflineNotify(this);
		}

		// Token: 0x170051BE RID: 20926
		// (get) Token: 0x06018425 RID: 99365 RVA: 0x00388165 File Offset: 0x00386365
		// (set) Token: 0x06018426 RID: 99366 RVA: 0x0038816D File Offset: 0x0038636D
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

		// Token: 0x170051BF RID: 20927
		// (get) Token: 0x06018427 RID: 99367 RVA: 0x00388176 File Offset: 0x00386376
		// (set) Token: 0x06018428 RID: 99368 RVA: 0x0038817E File Offset: 0x0038637E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOffline
		{
			get
			{
				return this.isOffline_;
			}
			set
			{
				this.isOffline_ = value;
			}
		}

		// Token: 0x170051C0 RID: 20928
		// (get) Token: 0x06018429 RID: 99369 RVA: 0x00388187 File Offset: 0x00386387
		// (set) Token: 0x0601842A RID: 99370 RVA: 0x0038818F File Offset: 0x0038638F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReLogin
		{
			get
			{
				return this.isReLogin_;
			}
			set
			{
				this.isReLogin_ = value;
			}
		}

		// Token: 0x0601842B RID: 99371 RVA: 0x00388198 File Offset: 0x00386398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScenePlayerOfflineNotify);
		}

		// Token: 0x0601842C RID: 99372 RVA: 0x003881A8 File Offset: 0x003863A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScenePlayerOfflineNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IsOffline == other.IsOffline && this.IsReLogin == other.IsReLogin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601842D RID: 99373 RVA: 0x00388204 File Offset: 0x00386404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IsOffline)
			{
				num ^= this.IsOffline.GetHashCode();
			}
			if (this.IsReLogin)
			{
				num ^= this.IsReLogin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601842E RID: 99374 RVA: 0x00388275 File Offset: 0x00386475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601842F RID: 99375 RVA: 0x00388282 File Offset: 0x00386482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018430 RID: 99376 RVA: 0x0038828C File Offset: 0x0038648C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsOffline)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsOffline);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IsReLogin)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsReLogin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018431 RID: 99377 RVA: 0x00388304 File Offset: 0x00386504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IsOffline)
			{
				num += 2;
			}
			if (this.IsReLogin)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018432 RID: 99378 RVA: 0x0038835C File Offset: 0x0038655C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScenePlayerOfflineNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IsOffline)
			{
				this.IsOffline = other.IsOffline;
			}
			if (other.IsReLogin)
			{
				this.IsReLogin = other.IsReLogin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018433 RID: 99379 RVA: 0x003883C0 File Offset: 0x003865C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018434 RID: 99380 RVA: 0x003883CC File Offset: 0x003865CC
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
				if (num != 80U)
				{
					if (num != 88U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsReLogin = input.ReadBool();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.IsOffline = input.ReadBool();
				}
			}
		}

		// Token: 0x04009038 RID: 36920
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009039 RID: 36921
		public const int PlayerIdFieldNumber = 11;

		// Token: 0x0400903A RID: 36922
		private int playerId_;

		// Token: 0x0400903B RID: 36923
		public const int IsOfflineFieldNumber = 10;

		// Token: 0x0400903C RID: 36924
		private bool isOffline_;

		// Token: 0x0400903D RID: 36925
		public const int IsReLoginFieldNumber = 15;

		// Token: 0x0400903E RID: 36926
		private bool isReLogin_;
	}
}
