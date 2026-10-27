using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000969 RID: 2409
	[NetMessage(EMessageId.LowMemoryChangeSceneStartNotify)]
	public sealed class LowMemoryChangeSceneStartNotify : IMessage<LowMemoryChangeSceneStartNotify>, IMessage, IEquatable<LowMemoryChangeSceneStartNotify>, IDeepCloneable<LowMemoryChangeSceneStartNotify>, IBufferMessage
	{
		// Token: 0x0600D426 RID: 54310 RVA: 0x001F3E81 File Offset: 0x001F2081
		[NullableContext(1)]
		public static LowMemoryChangeSceneStartNotify Create()
		{
			return new LowMemoryChangeSceneStartNotify();
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x0600D427 RID: 54311 RVA: 0x001F3E88 File Offset: 0x001F2088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x0600D428 RID: 54312 RVA: 0x001F3E8B File Offset: 0x001F208B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LowMemoryChangeSceneStartNotify.Descriptor;
			}
		}

		// Token: 0x0600D429 RID: 54313 RVA: 0x001F3E92 File Offset: 0x001F2092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneStartNotify()
		{
		}

		// Token: 0x0600D42A RID: 54314 RVA: 0x001F3EA5 File Offset: 0x001F20A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneStartNotify(LowMemoryChangeSceneStartNotify other) : this()
		{
			this.isSwitchHLOD_ = other.isSwitchHLOD_;
			this.assignLoadingBackgroundImagePath_ = other.assignLoadingBackgroundImagePath_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D42B RID: 54315 RVA: 0x001F3ED6 File Offset: 0x001F20D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneStartNotify Clone()
		{
			return new LowMemoryChangeSceneStartNotify(this);
		}

		// Token: 0x17002AF9 RID: 11001
		// (get) Token: 0x0600D42C RID: 54316 RVA: 0x001F3EDE File Offset: 0x001F20DE
		// (set) Token: 0x0600D42D RID: 54317 RVA: 0x001F3EE6 File Offset: 0x001F20E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSwitchHLOD
		{
			get
			{
				return this.isSwitchHLOD_;
			}
			set
			{
				this.isSwitchHLOD_ = value;
			}
		}

		// Token: 0x17002AFA RID: 11002
		// (get) Token: 0x0600D42E RID: 54318 RVA: 0x001F3EEF File Offset: 0x001F20EF
		// (set) Token: 0x0600D42F RID: 54319 RVA: 0x001F3EF7 File Offset: 0x001F20F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AssignLoadingBackgroundImagePath
		{
			get
			{
				return this.assignLoadingBackgroundImagePath_;
			}
			set
			{
				this.assignLoadingBackgroundImagePath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600D430 RID: 54320 RVA: 0x001F3F0A File Offset: 0x001F210A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LowMemoryChangeSceneStartNotify);
		}

		// Token: 0x0600D431 RID: 54321 RVA: 0x001F3F18 File Offset: 0x001F2118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LowMemoryChangeSceneStartNotify other)
		{
			return other != null && (other == this || (this.IsSwitchHLOD == other.IsSwitchHLOD && !(this.AssignLoadingBackgroundImagePath != other.AssignLoadingBackgroundImagePath) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D432 RID: 54322 RVA: 0x001F3F68 File Offset: 0x001F2168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsSwitchHLOD)
			{
				num ^= this.IsSwitchHLOD.GetHashCode();
			}
			if (this.AssignLoadingBackgroundImagePath.Length != 0)
			{
				num ^= this.AssignLoadingBackgroundImagePath.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D433 RID: 54323 RVA: 0x001F3FC2 File Offset: 0x001F21C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D434 RID: 54324 RVA: 0x001F3FCF File Offset: 0x001F21CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D435 RID: 54325 RVA: 0x001F3FD8 File Offset: 0x001F21D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AssignLoadingBackgroundImagePath.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.AssignLoadingBackgroundImagePath);
			}
			if (this.IsSwitchHLOD)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsSwitchHLOD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D436 RID: 54326 RVA: 0x001F4038 File Offset: 0x001F2238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsSwitchHLOD)
			{
				num += 2;
			}
			if (this.AssignLoadingBackgroundImagePath.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AssignLoadingBackgroundImagePath);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D437 RID: 54327 RVA: 0x001F4088 File Offset: 0x001F2288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LowMemoryChangeSceneStartNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsSwitchHLOD)
			{
				this.IsSwitchHLOD = other.IsSwitchHLOD;
			}
			if (other.AssignLoadingBackgroundImagePath.Length != 0)
			{
				this.AssignLoadingBackgroundImagePath = other.AssignLoadingBackgroundImagePath;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D438 RID: 54328 RVA: 0x001F40DD File Offset: 0x001F22DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D439 RID: 54329 RVA: 0x001F40E8 File Offset: 0x001F22E8
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
				if (num != 50U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsSwitchHLOD = input.ReadBool();
					}
				}
				else
				{
					this.AssignLoadingBackgroundImagePath = input.ReadString();
				}
			}
		}

		// Token: 0x0400590F RID: 22799
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005910 RID: 22800
		public const int IsSwitchHLODFieldNumber = 11;

		// Token: 0x04005911 RID: 22801
		private bool isSwitchHLOD_;

		// Token: 0x04005912 RID: 22802
		public const int AssignLoadingBackgroundImagePathFieldNumber = 6;

		// Token: 0x04005913 RID: 22803
		private string assignLoadingBackgroundImagePath_ = "";
	}
}
