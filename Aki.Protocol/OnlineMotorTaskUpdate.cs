using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B9F RID: 2975
	public sealed class OnlineMotorTaskUpdate : IMessage<OnlineMotorTaskUpdate>, IMessage, IEquatable<OnlineMotorTaskUpdate>, IDeepCloneable<OnlineMotorTaskUpdate>, IBufferMessage
	{
		// Token: 0x06010225 RID: 66085 RVA: 0x0025B048 File Offset: 0x00259248
		[NullableContext(1)]
		public static OnlineMotorTaskUpdate Create()
		{
			return new OnlineMotorTaskUpdate();
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x06010226 RID: 66086 RVA: 0x0025B04F File Offset: 0x0025924F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x06010227 RID: 66087 RVA: 0x0025B052 File Offset: 0x00259252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorTaskUpdate.Descriptor;
			}
		}

		// Token: 0x06010228 RID: 66088 RVA: 0x0025B059 File Offset: 0x00259259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorTaskUpdate()
		{
		}

		// Token: 0x06010229 RID: 66089 RVA: 0x0025B077 File Offset: 0x00259277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorTaskUpdate(OnlineMotorTaskUpdate other) : this()
		{
			this.levelTasks_ = other.levelTasks_.Clone();
			this.globalTasks_ = other.globalTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601022A RID: 66090 RVA: 0x0025B0B2 File Offset: 0x002592B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorTaskUpdate Clone()
		{
			return new OnlineMotorTaskUpdate(this);
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0601022B RID: 66091 RVA: 0x0025B0BA File Offset: 0x002592BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorTask> LevelTasks
		{
			get
			{
				return this.levelTasks_;
			}
		}

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0601022C RID: 66092 RVA: 0x0025B0C2 File Offset: 0x002592C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorTask> GlobalTasks
		{
			get
			{
				return this.globalTasks_;
			}
		}

		// Token: 0x0601022D RID: 66093 RVA: 0x0025B0CA File Offset: 0x002592CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorTaskUpdate);
		}

		// Token: 0x0601022E RID: 66094 RVA: 0x0025B0D8 File Offset: 0x002592D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorTaskUpdate other)
		{
			return other != null && (other == this || (this.levelTasks_.Equals(other.levelTasks_) && this.globalTasks_.Equals(other.globalTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601022F RID: 66095 RVA: 0x0025B12C File Offset: 0x0025932C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.levelTasks_.GetHashCode();
			num ^= this.globalTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010230 RID: 66096 RVA: 0x0025B16E File Offset: 0x0025936E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010231 RID: 66097 RVA: 0x0025B17B File Offset: 0x0025937B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010232 RID: 66098 RVA: 0x0025B184 File Offset: 0x00259384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.levelTasks_.WriteTo(ref output, OnlineMotorTaskUpdate._repeated_levelTasks_codec);
			this.globalTasks_.WriteTo(ref output, OnlineMotorTaskUpdate._repeated_globalTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010233 RID: 66099 RVA: 0x0025B1BC File Offset: 0x002593BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.levelTasks_.CalculateSize(OnlineMotorTaskUpdate._repeated_levelTasks_codec);
			num += this.globalTasks_.CalculateSize(OnlineMotorTaskUpdate._repeated_globalTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010234 RID: 66100 RVA: 0x0025B208 File Offset: 0x00259408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorTaskUpdate other)
		{
			if (other == null)
			{
				return;
			}
			this.levelTasks_.Add(other.levelTasks_);
			this.globalTasks_.Add(other.globalTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010235 RID: 66101 RVA: 0x0025B247 File Offset: 0x00259447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010236 RID: 66102 RVA: 0x0025B250 File Offset: 0x00259450
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
						this.globalTasks_.AddEntriesFrom(ref input, OnlineMotorTaskUpdate._repeated_globalTasks_codec);
					}
				}
				else
				{
					this.levelTasks_.AddEntriesFrom(ref input, OnlineMotorTaskUpdate._repeated_levelTasks_codec);
				}
			}
		}

		// Token: 0x040066D6 RID: 26326
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066D7 RID: 26327
		public const int LevelTasksFieldNumber = 1;

		// Token: 0x040066D8 RID: 26328
		private static readonly FieldCodec<OnlineMotorTask> _repeated_levelTasks_codec = FieldCodec.ForMessage<OnlineMotorTask>(10U, OnlineMotorTask.Parser);

		// Token: 0x040066D9 RID: 26329
		private readonly RepeatedField<OnlineMotorTask> levelTasks_ = new RepeatedField<OnlineMotorTask>();

		// Token: 0x040066DA RID: 26330
		public const int GlobalTasksFieldNumber = 2;

		// Token: 0x040066DB RID: 26331
		private static readonly FieldCodec<OnlineMotorTask> _repeated_globalTasks_codec = FieldCodec.ForMessage<OnlineMotorTask>(18U, OnlineMotorTask.Parser);

		// Token: 0x040066DC RID: 26332
		private readonly RepeatedField<OnlineMotorTask> globalTasks_ = new RepeatedField<OnlineMotorTask>();
	}
}
