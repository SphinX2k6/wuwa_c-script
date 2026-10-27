using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001185 RID: 4485
	[NetMessage(EMessageId.ScenePlayerOfflineNotify)]
	public sealed class ScenePlayerOfflineNotify : IMessage<ScenePlayerOfflineNotify>, IMessage, IEquatable<ScenePlayerOfflineNotify>, IDeepCloneable<ScenePlayerOfflineNotify>, IBufferMessage
	{
		// Token: 0x06017E7E RID: 97918 RVA: 0x00378DC3 File Offset: 0x00376FC3
		[NullableContext(1)]
		public static ScenePlayerOfflineNotify Create()
		{
			return new ScenePlayerOfflineNotify();
		}

		// Token: 0x17005050 RID: 20560
		// (get) Token: 0x06017E7F RID: 97919 RVA: 0x00378DCA File Offset: 0x00376FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005051 RID: 20561
		// (get) Token: 0x06017E80 RID: 97920 RVA: 0x00378DCD File Offset: 0x00376FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScenePlayerOfflineNotify.Descriptor;
			}
		}

		// Token: 0x06017E81 RID: 97921 RVA: 0x00378DD4 File Offset: 0x00376FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlayerOfflineNotify()
		{
		}

		// Token: 0x06017E82 RID: 97922 RVA: 0x00378DDC File Offset: 0x00376FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlayerOfflineNotify(ScenePlayerOfflineNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.isOffline_ = other.isOffline_;
			this.isReLogin_ = other.isReLogin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E83 RID: 97923 RVA: 0x00378E19 File Offset: 0x00377019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlayerOfflineNotify Clone()
		{
			return new ScenePlayerOfflineNotify(this);
		}

		// Token: 0x17005052 RID: 20562
		// (get) Token: 0x06017E84 RID: 97924 RVA: 0x00378E21 File Offset: 0x00377021
		// (set) Token: 0x06017E85 RID: 97925 RVA: 0x00378E29 File Offset: 0x00377029
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

		// Token: 0x17005053 RID: 20563
		// (get) Token: 0x06017E86 RID: 97926 RVA: 0x00378E32 File Offset: 0x00377032
		// (set) Token: 0x06017E87 RID: 97927 RVA: 0x00378E3A File Offset: 0x0037703A
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

		// Token: 0x17005054 RID: 20564
		// (get) Token: 0x06017E88 RID: 97928 RVA: 0x00378E43 File Offset: 0x00377043
		// (set) Token: 0x06017E89 RID: 97929 RVA: 0x00378E4B File Offset: 0x0037704B
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

		// Token: 0x06017E8A RID: 97930 RVA: 0x00378E54 File Offset: 0x00377054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScenePlayerOfflineNotify);
		}

		// Token: 0x06017E8B RID: 97931 RVA: 0x00378E64 File Offset: 0x00377064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScenePlayerOfflineNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IsOffline == other.IsOffline && this.IsReLogin == other.IsReLogin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017E8C RID: 97932 RVA: 0x00378EC0 File Offset: 0x003770C0
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

		// Token: 0x06017E8D RID: 97933 RVA: 0x00378F31 File Offset: 0x00377131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E8E RID: 97934 RVA: 0x00378F3E File Offset: 0x0037713E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E8F RID: 97935 RVA: 0x00378F48 File Offset: 0x00377148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsOffline)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsOffline);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(112);
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

		// Token: 0x06017E90 RID: 97936 RVA: 0x00378FC0 File Offset: 0x003771C0
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

		// Token: 0x06017E91 RID: 97937 RVA: 0x00379018 File Offset: 0x00377218
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

		// Token: 0x06017E92 RID: 97938 RVA: 0x0037907C File Offset: 0x0037727C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E93 RID: 97939 RVA: 0x00379088 File Offset: 0x00377288
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
					if (num != 112U)
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

		// Token: 0x04008DA5 RID: 36261
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DA6 RID: 36262
		public const int PlayerIdFieldNumber = 14;

		// Token: 0x04008DA7 RID: 36263
		private int playerId_;

		// Token: 0x04008DA8 RID: 36264
		public const int IsOfflineFieldNumber = 4;

		// Token: 0x04008DA9 RID: 36265
		private bool isOffline_;

		// Token: 0x04008DAA RID: 36266
		public const int IsReLoginFieldNumber = 15;

		// Token: 0x04008DAB RID: 36267
		private bool isReLogin_;
	}
}
