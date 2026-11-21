using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A81 RID: 2689
	public sealed class MotorParkourActivityInfo : IMessage<MotorParkourActivityInfo>, IMessage, IEquatable<MotorParkourActivityInfo>, IDeepCloneable<MotorParkourActivityInfo>, IBufferMessage
	{
		// Token: 0x0600EA91 RID: 60049 RVA: 0x00224708 File Offset: 0x00222908
		[NullableContext(1)]
		public static MotorParkourActivityInfo Create()
		{
			return new MotorParkourActivityInfo();
		}

		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x0600EA92 RID: 60050 RVA: 0x0022470F File Offset: 0x0022290F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x0600EA93 RID: 60051 RVA: 0x00224712 File Offset: 0x00222912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600EA94 RID: 60052 RVA: 0x00224719 File Offset: 0x00222919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourActivityInfo()
		{
		}

		// Token: 0x0600EA95 RID: 60053 RVA: 0x0022472C File Offset: 0x0022292C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourActivityInfo(MotorParkourActivityInfo other) : this()
		{
			this.motorParkourLevelInfos_ = other.motorParkourLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EA96 RID: 60054 RVA: 0x00224756 File Offset: 0x00222956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourActivityInfo Clone()
		{
			return new MotorParkourActivityInfo(this);
		}

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x0600EA97 RID: 60055 RVA: 0x0022475E File Offset: 0x0022295E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorParkourLevelInfo> MotorParkourLevelInfos
		{
			get
			{
				return this.motorParkourLevelInfos_;
			}
		}

		// Token: 0x0600EA98 RID: 60056 RVA: 0x00224766 File Offset: 0x00222966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourActivityInfo);
		}

		// Token: 0x0600EA99 RID: 60057 RVA: 0x00224774 File Offset: 0x00222974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourActivityInfo other)
		{
			return other != null && (other == this || (this.motorParkourLevelInfos_.Equals(other.motorParkourLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EA9A RID: 60058 RVA: 0x002247A8 File Offset: 0x002229A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.motorParkourLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EA9B RID: 60059 RVA: 0x002247DC File Offset: 0x002229DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EA9C RID: 60060 RVA: 0x002247E9 File Offset: 0x002229E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EA9D RID: 60061 RVA: 0x002247F2 File Offset: 0x002229F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.motorParkourLevelInfos_.WriteTo(ref output, MotorParkourActivityInfo._repeated_motorParkourLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EA9E RID: 60062 RVA: 0x0022481C File Offset: 0x00222A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.motorParkourLevelInfos_.CalculateSize(MotorParkourActivityInfo._repeated_motorParkourLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EA9F RID: 60063 RVA: 0x00224855 File Offset: 0x00222A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorParkourActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.motorParkourLevelInfos_.Add(other.motorParkourLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EAA0 RID: 60064 RVA: 0x00224883 File Offset: 0x00222A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EAA1 RID: 60065 RVA: 0x0022488C File Offset: 0x00222A8C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.motorParkourLevelInfos_.AddEntriesFrom(ref input, MotorParkourActivityInfo._repeated_motorParkourLevelInfos_codec);
				}
			}
		}

		// Token: 0x04005FA9 RID: 24489
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FAA RID: 24490
		public const int MotorParkourLevelInfosFieldNumber = 1;

		// Token: 0x04005FAB RID: 24491
		private static readonly FieldCodec<MotorParkourLevelInfo> _repeated_motorParkourLevelInfos_codec = FieldCodec.ForMessage<MotorParkourLevelInfo>(10U, MotorParkourLevelInfo.Parser);

		// Token: 0x04005FAC RID: 24492
		private readonly RepeatedField<MotorParkourLevelInfo> motorParkourLevelInfos_ = new RepeatedField<MotorParkourLevelInfo>();
	}
}
