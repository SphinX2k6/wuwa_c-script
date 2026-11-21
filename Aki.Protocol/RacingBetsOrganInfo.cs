using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E5D RID: 3677
	public sealed class RacingBetsOrganInfo : IMessage<RacingBetsOrganInfo>, IMessage, IEquatable<RacingBetsOrganInfo>, IDeepCloneable<RacingBetsOrganInfo>, IBufferMessage
	{
		// Token: 0x06013C94 RID: 81044 RVA: 0x002E27A0 File Offset: 0x002E09A0
		[NullableContext(1)]
		public static RacingBetsOrganInfo Create()
		{
			return new RacingBetsOrganInfo();
		}

		// Token: 0x170041D4 RID: 16852
		// (get) Token: 0x06013C95 RID: 81045 RVA: 0x002E27A7 File Offset: 0x002E09A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsOrganInfo> Parser
		{
			get
			{
				return RacingBetsOrganInfo._parser;
			}
		}

		// Token: 0x170041D5 RID: 16853
		// (get) Token: 0x06013C96 RID: 81046 RVA: 0x002E27AE File Offset: 0x002E09AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041D6 RID: 16854
		// (get) Token: 0x06013C97 RID: 81047 RVA: 0x002E27B1 File Offset: 0x002E09B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsOrganInfo.Descriptor;
			}
		}

		// Token: 0x06013C98 RID: 81048 RVA: 0x002E27B8 File Offset: 0x002E09B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsOrganInfo()
		{
		}

		// Token: 0x06013C99 RID: 81049 RVA: 0x002E27C0 File Offset: 0x002E09C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsOrganInfo(RacingBetsOrganInfo other) : this()
		{
			this.id_ = other.id_;
			this.point_ = other.point_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013C9A RID: 81050 RVA: 0x002E27F1 File Offset: 0x002E09F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsOrganInfo Clone()
		{
			return new RacingBetsOrganInfo(this);
		}

		// Token: 0x170041D7 RID: 16855
		// (get) Token: 0x06013C9B RID: 81051 RVA: 0x002E27F9 File Offset: 0x002E09F9
		// (set) Token: 0x06013C9C RID: 81052 RVA: 0x002E2801 File Offset: 0x002E0A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x170041D8 RID: 16856
		// (get) Token: 0x06013C9D RID: 81053 RVA: 0x002E280A File Offset: 0x002E0A0A
		// (set) Token: 0x06013C9E RID: 81054 RVA: 0x002E2812 File Offset: 0x002E0A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Point
		{
			get
			{
				return this.point_;
			}
			set
			{
				this.point_ = value;
			}
		}

		// Token: 0x06013C9F RID: 81055 RVA: 0x002E281B File Offset: 0x002E0A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsOrganInfo);
		}

		// Token: 0x06013CA0 RID: 81056 RVA: 0x002E2829 File Offset: 0x002E0A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsOrganInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Point == other.Point && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013CA1 RID: 81057 RVA: 0x002E2868 File Offset: 0x002E0A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013CA2 RID: 81058 RVA: 0x002E28C0 File Offset: 0x002E0AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013CA3 RID: 81059 RVA: 0x002E28CD File Offset: 0x002E0ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013CA4 RID: 81060 RVA: 0x002E28D8 File Offset: 0x002E0AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Point);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013CA5 RID: 81061 RVA: 0x002E2930 File Offset: 0x002E0B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013CA6 RID: 81062 RVA: 0x002E2988 File Offset: 0x002E0B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsOrganInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013CA7 RID: 81063 RVA: 0x002E29D8 File Offset: 0x002E0BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013CA8 RID: 81064 RVA: 0x002E29E4 File Offset: 0x002E0BE4
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Point = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007992 RID: 31122
		private static readonly MessageParser<RacingBetsOrganInfo> _parser = new MessageParser<RacingBetsOrganInfo>(() => new RacingBetsOrganInfo());

		// Token: 0x04007993 RID: 31123
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007994 RID: 31124
		public const int IdFieldNumber = 1;

		// Token: 0x04007995 RID: 31125
		private int id_;

		// Token: 0x04007996 RID: 31126
		public const int PointFieldNumber = 2;

		// Token: 0x04007997 RID: 31127
		private int point_;
	}
}
