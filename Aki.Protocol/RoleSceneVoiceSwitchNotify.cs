using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001097 RID: 4247
	[NetMessage(EMessageId.RoleSceneVoiceSwitchNotify)]
	public sealed class RoleSceneVoiceSwitchNotify : IMessage<RoleSceneVoiceSwitchNotify>, IMessage, IEquatable<RoleSceneVoiceSwitchNotify>, IDeepCloneable<RoleSceneVoiceSwitchNotify>, IBufferMessage
	{
		// Token: 0x06016B5E RID: 93022 RVA: 0x0034D97A File Offset: 0x0034BB7A
		[NullableContext(1)]
		public static RoleSceneVoiceSwitchNotify Create()
		{
			return new RoleSceneVoiceSwitchNotify();
		}

		// Token: 0x17004C20 RID: 19488
		// (get) Token: 0x06016B5F RID: 93023 RVA: 0x0034D981 File Offset: 0x0034BB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C21 RID: 19489
		// (get) Token: 0x06016B60 RID: 93024 RVA: 0x0034D984 File Offset: 0x0034BB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSceneVoiceSwitchNotify.Descriptor;
			}
		}

		// Token: 0x06016B61 RID: 93025 RVA: 0x0034D98B File Offset: 0x0034BB8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSceneVoiceSwitchNotify()
		{
		}

		// Token: 0x06016B62 RID: 93026 RVA: 0x0034D993 File Offset: 0x0034BB93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSceneVoiceSwitchNotify(RoleSceneVoiceSwitchNotify other) : this()
		{
			this.voiceGroupData_ = other.voiceGroupData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016B63 RID: 93027 RVA: 0x0034D9B8 File Offset: 0x0034BBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSceneVoiceSwitchNotify Clone()
		{
			return new RoleSceneVoiceSwitchNotify(this);
		}

		// Token: 0x17004C22 RID: 19490
		// (get) Token: 0x06016B64 RID: 93028 RVA: 0x0034D9C0 File Offset: 0x0034BBC0
		// (set) Token: 0x06016B65 RID: 93029 RVA: 0x0034D9C8 File Offset: 0x0034BBC8
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

		// Token: 0x06016B66 RID: 93030 RVA: 0x0034D9D1 File Offset: 0x0034BBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSceneVoiceSwitchNotify);
		}

		// Token: 0x06016B67 RID: 93031 RVA: 0x0034D9DF File Offset: 0x0034BBDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSceneVoiceSwitchNotify other)
		{
			return other != null && (other == this || (this.VoiceGroupData == other.VoiceGroupData && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B68 RID: 93032 RVA: 0x0034DA10 File Offset: 0x0034BC10
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

		// Token: 0x06016B69 RID: 93033 RVA: 0x0034DA4F File Offset: 0x0034BC4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B6A RID: 93034 RVA: 0x0034DA5C File Offset: 0x0034BC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B6B RID: 93035 RVA: 0x0034DA65 File Offset: 0x0034BC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VoiceGroupData != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.VoiceGroupData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016B6C RID: 93036 RVA: 0x0034DA98 File Offset: 0x0034BC98
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

		// Token: 0x06016B6D RID: 93037 RVA: 0x0034DAD6 File Offset: 0x0034BCD6
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

		// Token: 0x06016B6E RID: 93038 RVA: 0x0034DB07 File Offset: 0x0034BD07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B6F RID: 93039 RVA: 0x0034DB10 File Offset: 0x0034BD10
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.VoiceGroupData = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008821 RID: 34849
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008822 RID: 34850
		public const int VoiceGroupDataFieldNumber = 11;

		// Token: 0x04008823 RID: 34851
		private int voiceGroupData_;
	}
}
