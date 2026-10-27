using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A7 RID: 4263
	[NetMessage(EMessageId.RoleSceneVoiceSwitchNotify)]
	public sealed class RoleSceneVoiceSwitchNotify : IMessage<RoleSceneVoiceSwitchNotify>, IMessage, IEquatable<RoleSceneVoiceSwitchNotify>, IDeepCloneable<RoleSceneVoiceSwitchNotify>, IBufferMessage
	{
		// Token: 0x06016C43 RID: 93251 RVA: 0x0034F056 File Offset: 0x0034D256
		[NullableContext(1)]
		public static RoleSceneVoiceSwitchNotify Create()
		{
			return new RoleSceneVoiceSwitchNotify();
		}

		// Token: 0x17004C4A RID: 19530
		// (get) Token: 0x06016C44 RID: 93252 RVA: 0x0034F05D File Offset: 0x0034D25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C4B RID: 19531
		// (get) Token: 0x06016C45 RID: 93253 RVA: 0x0034F060 File Offset: 0x0034D260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSceneVoiceSwitchNotify.Descriptor;
			}
		}

		// Token: 0x06016C46 RID: 93254 RVA: 0x0034F067 File Offset: 0x0034D267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSceneVoiceSwitchNotify()
		{
		}

		// Token: 0x06016C47 RID: 93255 RVA: 0x0034F06F File Offset: 0x0034D26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSceneVoiceSwitchNotify(RoleSceneVoiceSwitchNotify other) : this()
		{
			this.voiceGroupData_ = other.voiceGroupData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016C48 RID: 93256 RVA: 0x0034F094 File Offset: 0x0034D294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSceneVoiceSwitchNotify Clone()
		{
			return new RoleSceneVoiceSwitchNotify(this);
		}

		// Token: 0x17004C4C RID: 19532
		// (get) Token: 0x06016C49 RID: 93257 RVA: 0x0034F09C File Offset: 0x0034D29C
		// (set) Token: 0x06016C4A RID: 93258 RVA: 0x0034F0A4 File Offset: 0x0034D2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int VoiceGroupData
		{
			get
			{
				return this.voiceGroupData_;
			}
			set
			{
				this.voiceGroupData_ = value;
			}
		}

		// Token: 0x06016C4B RID: 93259 RVA: 0x0034F0AD File Offset: 0x0034D2AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSceneVoiceSwitchNotify);
		}

		// Token: 0x06016C4C RID: 93260 RVA: 0x0034F0BB File Offset: 0x0034D2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSceneVoiceSwitchNotify other)
		{
			return other != null && (other == this || (this.VoiceGroupData == other.VoiceGroupData && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C4D RID: 93261 RVA: 0x0034F0EC File Offset: 0x0034D2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.VoiceGroupData != 0)
			{
				num ^= this.VoiceGroupData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016C4E RID: 93262 RVA: 0x0034F12B File Offset: 0x0034D32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C4F RID: 93263 RVA: 0x0034F138 File Offset: 0x0034D338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C50 RID: 93264 RVA: 0x0034F141 File Offset: 0x0034D341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VoiceGroupData != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.VoiceGroupData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C51 RID: 93265 RVA: 0x0034F174 File Offset: 0x0034D374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.VoiceGroupData != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.VoiceGroupData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016C52 RID: 93266 RVA: 0x0034F1B2 File Offset: 0x0034D3B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSceneVoiceSwitchNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VoiceGroupData != 0)
			{
				this.VoiceGroupData = other.VoiceGroupData;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016C53 RID: 93267 RVA: 0x0034F1E3 File Offset: 0x0034D3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C54 RID: 93268 RVA: 0x0034F1EC File Offset: 0x0034D3EC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.VoiceGroupData = input.ReadInt32();
				}
			}
		}

		// Token: 0x040087F7 RID: 34807
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087F8 RID: 34808
		public const int VoiceGroupDataFieldNumber = 6;

		// Token: 0x040087F9 RID: 34809
		private int voiceGroupData_;
	}
}
