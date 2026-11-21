using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000958 RID: 2392
	[NetMessage(EMessageId.LowMemoryChangeSceneStartNotify)]
	public sealed class LowMemoryChangeSceneStartNotify : IMessage<LowMemoryChangeSceneStartNotify>, IMessage, IEquatable<LowMemoryChangeSceneStartNotify>, IDeepCloneable<LowMemoryChangeSceneStartNotify>, IBufferMessage
	{
		// Token: 0x0600D30C RID: 54028 RVA: 0x001F1C99 File Offset: 0x001EFE99
		[NullableContext(1)]
		public static LowMemoryChangeSceneStartNotify Create()
		{
			return new LowMemoryChangeSceneStartNotify();
		}

		// Token: 0x17002AB9 RID: 10937
		// (get) Token: 0x0600D30D RID: 54029 RVA: 0x001F1CA0 File Offset: 0x001EFEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ABA RID: 10938
		// (get) Token: 0x0600D30E RID: 54030 RVA: 0x001F1CA3 File Offset: 0x001EFEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LowMemoryChangeSceneStartNotify.Descriptor;
			}
		}

		// Token: 0x0600D30F RID: 54031 RVA: 0x001F1CAA File Offset: 0x001EFEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneStartNotify()
		{
		}

		// Token: 0x0600D310 RID: 54032 RVA: 0x001F1CBD File Offset: 0x001EFEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneStartNotify(LowMemoryChangeSceneStartNotify other) : this()
		{
			this.isSwitchHLOD_ = other.isSwitchHLOD_;
			this.assignLoadingBackgroundImagePath_ = other.assignLoadingBackgroundImagePath_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D311 RID: 54033 RVA: 0x001F1CEE File Offset: 0x001EFEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LowMemoryChangeSceneStartNotify Clone()
		{
			return new LowMemoryChangeSceneStartNotify(this);
		}

		// Token: 0x17002ABB RID: 10939
		// (get) Token: 0x0600D312 RID: 54034 RVA: 0x001F1CF6 File Offset: 0x001EFEF6
		// (set) Token: 0x0600D313 RID: 54035 RVA: 0x001F1CFE File Offset: 0x001EFEFE
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

		// Token: 0x17002ABC RID: 10940
		// (get) Token: 0x0600D314 RID: 54036 RVA: 0x001F1D07 File Offset: 0x001EFF07
		// (set) Token: 0x0600D315 RID: 54037 RVA: 0x001F1D0F File Offset: 0x001EFF0F
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

		// Token: 0x0600D316 RID: 54038 RVA: 0x001F1D22 File Offset: 0x001EFF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LowMemoryChangeSceneStartNotify);
		}

		// Token: 0x0600D317 RID: 54039 RVA: 0x001F1D30 File Offset: 0x001EFF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LowMemoryChangeSceneStartNotify other)
		{
			return other != null && (other == this || (this.IsSwitchHLOD == other.IsSwitchHLOD && !(this.AssignLoadingBackgroundImagePath != other.AssignLoadingBackgroundImagePath) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D318 RID: 54040 RVA: 0x001F1D80 File Offset: 0x001EFF80
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

		// Token: 0x0600D319 RID: 54041 RVA: 0x001F1DDA File Offset: 0x001EFFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D31A RID: 54042 RVA: 0x001F1DE7 File Offset: 0x001EFFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D31B RID: 54043 RVA: 0x001F1DF0 File Offset: 0x001EFFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsSwitchHLOD)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsSwitchHLOD);
			}
			if (this.AssignLoadingBackgroundImagePath.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.AssignLoadingBackgroundImagePath);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D31C RID: 54044 RVA: 0x001F1E50 File Offset: 0x001F0050
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

		// Token: 0x0600D31D RID: 54045 RVA: 0x001F1EA0 File Offset: 0x001F00A0
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

		// Token: 0x0600D31E RID: 54046 RVA: 0x001F1EF5 File Offset: 0x001F00F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D31F RID: 54047 RVA: 0x001F1F00 File Offset: 0x001F0100
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
				if (num != 16U)
				{
					if (num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AssignLoadingBackgroundImagePath = input.ReadString();
					}
				}
				else
				{
					this.IsSwitchHLOD = input.ReadBool();
				}
			}
		}

		// Token: 0x04005918 RID: 22808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005919 RID: 22809
		public const int IsSwitchHLODFieldNumber = 2;

		// Token: 0x0400591A RID: 22810
		private bool isSwitchHLOD_;

		// Token: 0x0400591B RID: 22811
		public const int AssignLoadingBackgroundImagePathFieldNumber = 4;

		// Token: 0x0400591C RID: 22812
		private string assignLoadingBackgroundImagePath_ = "";
	}
}
